using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Foundations.HLSL
{
    internal class GeometryEntryPointTranslator : IEntryPointTranslator
    {
        // Expected input primitive sizes. See: https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-geometry-shader
        static Dictionary<GeometryInputType, int> _primitiveInputSizes = new Dictionary<GeometryInputType, int>()
        {
            [GeometryInputType.Point] = 1,
            [GeometryInputType.Line] = 2,
            [GeometryInputType.Triangle] = 3,
            [GeometryInputType.LineWithAdjacency] = 4,
            [GeometryInputType.TriangleWithAdjacency] = 6,
        };

        public string Translate(ShaderContext context, EntryPoint ep, ref string header)
        {
            SeparatedSyntaxList<AttributeArgumentSyntax> args = ep.AttributeSyntax.ArgumentList.Arguments;
            if (args.Count > 1)
            {
                string strInputType = args[0].ToString().Replace($"{nameof(GeometryInputType)}.", "");

                if (Enum.TryParse(strInputType, out GeometryInputType outputType))
                {
                    // Second argument is the output vertex count
                    string strVertexOutCount = args[1].ToString();
                    string result = header;

                    if (int.TryParse(strVertexOutCount, out int vertexOutCount))
                    {
                        result = $"{header.Replace(ep.MethodSyntax.AttributeLists.ToString(), $"[maxvertexcount({vertexOutCount})]").Trim()}{Environment.NewLine}";
                    }
                    else
                        context.Parent.AddMessage($"Invalid FragmentShaderAttribute slot value. Expected value greater than, or equal to 0. Got: {strVertexOutCount}", 0, 0);

                    return result;
                }
                else
                {
                    context.Parent.AddMessage($"Invalid geometry input type: {strInputType}", 0, 0);
                }
            }

            return header;
        }
    }
}
