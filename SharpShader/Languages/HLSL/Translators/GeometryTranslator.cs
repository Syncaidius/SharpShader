using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Languages.HLSL.Translators
{
    internal class GeometryTranslator : DefaultEntryPointTranslator
    {
        // Expected input primitive sizes and names. See: https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-geometry-shader
        static Dictionary<GeometryInputType, (int, string)> _primitiveInputs = new Dictionary<GeometryInputType, (int, string)>()
        {
            [GeometryInputType.Point] = (1, "point"),
            [GeometryInputType.Line] = (2, "line"),
            [GeometryInputType.Triangle] = (3, "triangle"),
            [GeometryInputType.LineWithAdjacency] = (4, "lineadj"),
            [GeometryInputType.TriangleWithAdjacency] = (6, "triangleadj")
        };

        public override void TranslateParameterPostfix(ShaderContext sc, ParameterSyntax syntax, EntryPoint ep, ParameterInfo pInfo, IEnumerable<Attribute> attributes, int parameterIndex)
        {
            GeometryShaderAttribute attGeo = ep.Attribute as GeometryShaderAttribute;

            if (pInfo.ParameterType.IsArray && pInfo.ParameterType.GetElementType().IsValueType)
            {
                (int inputVertices, string inputType) = _primitiveInputs[attGeo.InputType];
                sc.Source.Append($"[{inputVertices}]");
            }
        }

        public override void TranslateParameterPrefix(ShaderContext sc, ParameterSyntax syntax, EntryPoint ep, ParameterInfo pInfo, IEnumerable<Attribute> attributes, int parameterIndex)
        {
            GeometryShaderAttribute attGeo = ep.Attribute as GeometryShaderAttribute;

            if (pInfo.ParameterType.IsGenericType)
            {
                Type geoStreamType = typeof(GeometryShaderOutStream<>);
                geoStreamType = geoStreamType.MakeGenericType(pInfo.ParameterType.GenericTypeArguments);

                if (geoStreamType.IsAssignableFrom(pInfo.ParameterType))
                    sc.Source.Append("inout ");
            }
            else if (pInfo.ParameterType.IsArray && pInfo.ParameterType.GetElementType().IsValueType)
            {
                (int inputVertices, string inputType) = _primitiveInputs[attGeo.InputType];
                sc.Source.Append($"{inputType} ");
            }

            base.TranslateParameterPrefix(sc, syntax, ep, pInfo, attributes, parameterIndex);
        }

        public override void TranslatePrefix(ShaderContext sc, MethodInfo info, MethodDeclarationSyntax syntax, EntryPoint ep)
        {
            GeometryShaderAttribute attGeo = ep.Attribute as GeometryShaderAttribute;

            sc.Source.Append($"[maxvertexcount({attGeo.MaxVertexOutCount})]");
            sc.Source.AppendLineBreak();
        }
    }
}
