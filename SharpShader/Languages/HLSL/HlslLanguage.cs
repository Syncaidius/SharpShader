using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class HlslLanguage : ShaderLanguage
    {
        static readonly Dictionary<EntryPointType, string> _profileNames = new Dictionary<EntryPointType, string>()
        {
            [EntryPointType.ComputeShader] = "cs",
            [EntryPointType.DomainShader] = "ds",
            [EntryPointType.FragmentShader] = "ps",
            [EntryPointType.GeometryShader] = "gs",
            [EntryPointType.HullShader] = "hs",
            [EntryPointType.VertexShader] = "vs",
        };

        public HlslLanguage(OutputLanguage language) : base(language) { }

        internal override bool InstancedConstantBuffers => false;

        private void TranslatePostfixAttributes(ShaderContext sc, IEnumerable<Attribute> attributes, char? registerName, bool isConstBuffer)
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
                            sc.Source.Append($" : register({registerName}{regAtt.Slot})");
                        }
                        else
                        {
                            string profile = regAtt.Model.ToString().Replace("SM", _profileNames[regAtt.ApplicableEntryPoint]);
                            sc.Source.Append($" : register({profile}, {registerName}{regAtt.Slot})");
                        }
                        break;

                    case PackOffsetAttribute packAtt:
                        if (!isConstBuffer)
                            continue;

                        if (packAtt.OffsetComponent != PackOffsetComponent.X)
                        {
                            string componentName = packAtt.OffsetComponent.ToString().ToLower();
                            sc.Source.Append($" : packoffset(c{packAtt.OffsetRegister}.{componentName})");
                        }
                        else
                        {
                            sc.Source.Append($" : packoffset(c{packAtt.OffsetRegister})");
                        } 
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
            TranslatePostfixAttributes(sc, attributes, 'b', true);
        }

        internal override void TranslateFieldPrefix(ShaderContext sc, VariableDeclaratorSyntax syntax, FieldInfo info, IEnumerable<Attribute> attributes)
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

        internal override void TranslateFieldPostfix(ShaderContext sc, VariableDeclaratorSyntax syntax, FieldInfo info, IEnumerable<Attribute> attributes)
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

            TranslatePostfixAttributes(sc, attributes, regName, inConstantBuffer);
        }

        internal override void TranslateEntryPointPrefix(ShaderContext sc, MethodInfo info, MethodDeclarationSyntax syntax, EntryPoint ep)
        {
            switch (ep.Attribute)
            {
                case GeometryShaderAttribute attGeo:

                    break;
            }
            // TODO hull, domain, geometry, pixel shader attributes.
        }

        internal override void TranslateEntryPointPostfix(ShaderContext sc, MethodInfo info, MethodDeclarationSyntax syntax, EntryPoint ep)
        {
            // TODO validate that the input/output semantic types used are correct for each entry point type.

            switch (ep.Attribute)
            {
                case VertexShaderAttribute attVertex:
                    if (attVertex.OutputSemantic != SemanticType.None)
                    {
                        sc.Source.Append($" : {attVertex.OutputSemantic.ToString().ToUpper()}");
                        if (attVertex.SemanticSlot > -1)
                            sc.Source.Append(attVertex.SemanticSlot.ToString());
                    }
                    break;

                case FragmentShaderAttribute attFrag:
                    if (attFrag.OutputSemantic != SemanticType.None)
                    {
                        sc.Source.Append($" : {attFrag.OutputSemantic.ToString().ToUpper()}");
                        if (attFrag.SemanticSlot > -1)
                            sc.Source.Append(attFrag.SemanticSlot.ToString());
                    }
                    break;

                case GeometryShaderAttribute attGeo:

                    break;

                case HullShaderAttribute attHull:

                    break;

                case DomainShaderAttribute attDomain:

                    break;

                case ComputeShaderAttribute attCompute:

                    break;
            }
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
    }
}
