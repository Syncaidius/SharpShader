using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SharpShader.Languages;
using SharpShader.Languages.HLSL.Translators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class HlslLanguage : ShaderLanguage
    {
        const int COMPONENTS_PER_REGISTER = 4;
        const int COMPONENT_BYTE_SIZE = 4; // A register component is the size of a 32-bit floating-point value (i.e. C# float).

        static readonly Dictionary<EntryPointType, string> _profileNames = new Dictionary<EntryPointType, string>()
        {
            [EntryPointType.ComputeShader] = "cs",
            [EntryPointType.DomainShader] = "ds",
            [EntryPointType.FragmentShader] = "ps",
            [EntryPointType.GeometryShader] = "gs",
            [EntryPointType.HullShader] = "hs",
            [EntryPointType.VertexShader] = "vs",
        };

        static readonly Dictionary<EntryPointType, IEntryPointTranslator> _epTranslators = new Dictionary<EntryPointType, IEntryPointTranslator>()
        {
            [EntryPointType.VertexShader] = new DefaultEntryPointTranslator(),
            [EntryPointType.FragmentShader] = new DefaultEntryPointTranslator(),
            [EntryPointType.GeometryShader] = new GeometryTranslator(),
            [EntryPointType.HullShader] = new HullTranslator(),
            [EntryPointType.DomainShader] = new DomainTranslator(),
            [EntryPointType.ComputeShader] = new ComputeTranslator(),
        };

        public HlslLanguage(OutputLanguage language) : base(language) { }

        internal override bool InstancedConstantBuffers => false;

        internal override IEntryPointTranslator GetEntryPoinTranslator(EntryPointType type)
        {
            if (_epTranslators.TryGetValue(type, out IEntryPointTranslator translator))
                return translator;
            else
                return null;
        }

        private void TranslatePostfixAttributes(ShaderTranslationContext sc, IEnumerable<Attribute> attributes, char? registerName, int fieldIndex, int fieldSize, MappedConstantBuffer cBuffer)
        {
            foreach (Attribute a in attributes)
            {
                switch (a)
                {
                    case RegisterAttribute regAtt:
                        if (registerName == null)
                            continue;

                        int slotID = (int)(regAtt.Slot + fieldIndex);
                        cBuffer?.BindSlots.Add(new BindPointInfo(regAtt.Model, regAtt.ApplicableEntryPoint, slotID));

                        if (regAtt.ApplicableEntryPoint == EntryPointType.AnyOrNone)
                        {
                            sc.Source.Append($" : register({registerName}{slotID})");
                        }
                        else
                        {
                            string profile = regAtt.Model.ToString().Replace("SM", _profileNames[regAtt.ApplicableEntryPoint]);
                            sc.Source.Append($" : register({profile}, {registerName}{slotID})");
                        }
                        break;

                    case PackOffsetAttribute packAtt:
                        if (cBuffer == null)
                            continue;

                        int totalComponentOffset = (packAtt.OffsetRegister * COMPONENTS_PER_REGISTER) + (int)packAtt.OffsetComponent;
                        totalComponentOffset += (int)Math.Floor((fieldSize * fieldIndex) / (float)COMPONENT_BYTE_SIZE);
                        PackOffsetComponent component = (PackOffsetComponent)(totalComponentOffset % COMPONENTS_PER_REGISTER);
                        int register = (int)Math.Floor(totalComponentOffset / (float)COMPONENTS_PER_REGISTER);

                        string componentName = component.ToString().ToLower();
                        sc.Source.Append($" : packoffset(c{register}.{componentName})");
 
                        break;

                    case SemanticAttribute semAtt:
                        if (cBuffer != null)
                            continue;

                        string semanticName = semAtt.Semantic.ToString().ToUpper();
                        sc.Source.Append($" : {semanticName}");

                        if (semAtt.Slot >= 0)
                            sc.Source.Append(semAtt.Slot.ToString());
                        break;
                }
            }
        }

        internal override void TranslateConstBufferHeader(ShaderTranslationContext sc, StructDeclarationSyntax syntax, MappedConstantBuffer cBufferMap, IEnumerable<Attribute> attributes)
        {
            sc.Source.Append($"{Environment.NewLine}cbuffer {cBufferMap.TypeInfo.Name}");
            TranslatePostfixAttributes(sc, attributes, 'b', 0, 0, cBufferMap);
        }

        internal override void TranslateFieldPrefix(ShaderTranslationContext sc, VariableDeclaratorSyntax syntax, MappedField field, int fieldIndex, MappedConstantBuffer cBufferMap)
        {
            if (typeof(IMatrix).IsAssignableFrom(field.Info.FieldType))
            {
                if (field.StructureType == ShaderStructureType.MatrixRowMajor)
                    sc.Source.Append("row_major ");
                if (field.StructureType == ShaderStructureType.MatrixColumnMajor)
                    sc.Source.Append("column_Major ");
            }

            foreach(Attribute at in field.Attributes)
            {
                switch (at)
                {
                    case InterpolationAttribute attInterpolation:
                        foreach (InterpolationMode m in InterpolationAttribute.ModeValues)
                        {
                            if (m == InterpolationMode.None)
                                continue;

                            if ((attInterpolation.Flags & m) == m)
                                sc.Source.Append($" {m.ToString().ToLower()}");
                        }
                        break;

                    case ComputeGroupSharedAttribute attGroupShared:
                        sc.Source.Append($" groupshared ");
                        break;
                }
            }
        }

        internal override void TranslateFieldPostfix(ShaderTranslationContext sc, VariableDeclaratorSyntax syntax, MappedField field, int fieldIndex, MappedConstantBuffer cBufferMap)
        {
            char? regName = null;

            // Constant buffer fields do not have registers assigned to them.
            if (cBufferMap == null)
            {
                if (sc.Samplers.ContainsKey(field.Info.Name))
                    regName = 's';
                else if (sc.Textures.ContainsKey(field.Info.Name) || sc.Buffers.ContainsKey(field.Info.Name))
                    regName = 't';
                else if (sc.UAVs.ContainsKey(field.Info.Name))
                    regName = 'u';
            }

            int fieldTypeSize = field.Info.FieldType.IsValueType ? Marshal.SizeOf(field.Info.FieldType) : 0;
            TranslatePostfixAttributes(sc, field.Attributes, regName, fieldIndex, fieldTypeSize, cBufferMap);
        }

        internal override string TranslateNumber(ShaderTranslationContext context, string number)
        {
            // NOTE: hexadecimal literals are supported in HLSL, binary literals are not, so we'll need to translate those.
            if (number.StartsWith("0b")) // Binary literal.
            {
                return TranslateBinaryLiteral(number);
            }
            else // Hexadecimal + everything else.
            {
                int newLength = number.Length;
                for(int i = number.Length - 1; i >= 0; i--)
                {
                    if (!char.IsNumber(number[i]))
                    {
                        newLength = i;
                        break;
                    }
                }
                return number.Substring(0, newLength);
            }
        }

        internal override void TranslateForLoopPrefix(ShaderTranslationContext sc, ForStatementSyntax syntax)
        {
            // TODO Only unroll if loop iteration count is low enough.
            sc.Source.Append("[unroll]");
        }
    }
}
