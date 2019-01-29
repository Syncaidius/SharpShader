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
            [EntryPointType.VertexShader] = new VertexTranslator(),
            [EntryPointType.FragmentShader] = new PixelTranslator(),
            [EntryPointType.GeometryShader] = new GeometryTranslator(),
            [EntryPointType.HullShader] = new HullTranslator(),
            [EntryPointType.DomainShader] = new DomainTranslator(),
            [EntryPointType.ComputeShader] = null,
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

        private void TranslatePostfixAttributes(ShaderContext sc, IEnumerable<Attribute> attributes, char? registerName, bool isConstBuffer, int fieldIndex, int fieldSize)
        {
            foreach (Attribute a in attributes)
            {
                switch (a)
                {
                    case RegisterAttribute regAtt:
                        if (registerName == null)
                            continue;

                        if (regAtt.ApplicableEntryPoint == EntryPointType.AnyOrNone)
                        {
                            sc.Source.Append($" : register({registerName}{regAtt.Slot + fieldIndex})");
                        }
                        else
                        {
                            string profile = regAtt.Model.ToString().Replace("SM", _profileNames[regAtt.ApplicableEntryPoint]);
                            sc.Source.Append($" : register({profile}, {registerName}{regAtt.Slot + fieldIndex})");
                        }
                        break;

                    case PackOffsetAttribute packAtt:
                        if (!isConstBuffer)
                            continue;

                        int totalComponentOffset = (packAtt.OffsetRegister * COMPONENTS_PER_REGISTER) + (int)packAtt.OffsetComponent;
                        totalComponentOffset += (int)Math.Floor((fieldSize * fieldIndex) / (float)COMPONENT_BYTE_SIZE);
                        PackOffsetComponent component = (PackOffsetComponent)(totalComponentOffset % COMPONENTS_PER_REGISTER);
                        int register = (int)Math.Floor(totalComponentOffset / (float)COMPONENTS_PER_REGISTER);

                        string componentName = component.ToString().ToLower();
                        sc.Source.Append($" : packoffset(c{register}.{componentName})");
 
                        break;

                    case SemanticAttribute semAtt:
                        if (isConstBuffer)
                            continue;

                        string semanticName = semAtt.Semantic.ToString().ToUpper();
                        sc.Source.Append($" : {semanticName}");

                        if (semAtt.Slot >= 0)
                            sc.Source.Append(semAtt.Slot.ToString());
                        break;
                }
            }
        }

        internal override void TranslateConstBufferHeader(ShaderContext sc, StructDeclarationSyntax syntax, Type cBufferInfo, IEnumerable<Attribute> attributes)
        {
            sc.Source.Append($"{Environment.NewLine}cbuffer {cBufferInfo.Name}");
            TranslatePostfixAttributes(sc, attributes, 'b', true, 0, 0);
        }

        internal override void TranslateFieldPrefix(ShaderContext sc, VariableDeclaratorSyntax syntax, FieldInfo info, IEnumerable<Attribute> attributes, int fieldIndex)
        {
            InterpolationAttribute attInterpolation = info.GetCustomAttribute<InterpolationAttribute>();
            if (attInterpolation != null)
            {
                foreach(InterpolationMode m in InterpolationAttribute.ModeValues)
                {
                    if (m == InterpolationMode.None)
                        continue;

                    if((attInterpolation.Flags & m) == m)
                        sc.Source.Append($" {m.ToString().ToLower()}");
                }
            }
        }

        internal override void TranslateFieldPostfix(ShaderContext sc, VariableDeclaratorSyntax syntax, FieldInfo info, IEnumerable<Attribute> attributes, int fieldIndex)
        {
            char? regName = null;
            bool inConstantBuffer = false;

            if (info.DeclaringType?.IsValueType == true)
                inConstantBuffer = sc.ConstantBuffers.ContainsKey(info.DeclaringType.Name);

            if (sc.Samplers.ContainsKey(info.Name))
                regName = 's';
            else if (sc.Textures.ContainsKey(info.Name) || sc.Buffers.ContainsKey(info.Name))
                regName = 't';
            else if (sc.UAVs.ContainsKey(info.Name))
                regName = 'u';

            int fieldTypeSize = info.FieldType.IsValueType ? Marshal.SizeOf(info.FieldType) : 0;
            TranslatePostfixAttributes(sc, attributes, regName, inConstantBuffer, fieldIndex, fieldTypeSize);
        }

        internal override string TranslateNumber(ShaderContext context, string number)
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

        internal override void TranslateForLoopPrefix(ShaderContext sc, ForStatementSyntax syntax)
        {
            // TODO Only unroll if loop iteration count is low enough.
            sc.Source.Append("[unroll]");
        }
    }
}
