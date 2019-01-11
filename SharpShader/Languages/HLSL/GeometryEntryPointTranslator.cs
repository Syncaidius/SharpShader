//using Microsoft.CodeAnalysis;
//using Microsoft.CodeAnalysis.CSharp.Syntax;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SharpShader.Foundations.HLSL
//{
//    internal class GeometryEntryPointTranslator : IEntryPointTranslator
//    {
//        // Expected input primitive sizes and names. See: https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-geometry-shader
//        static Dictionary<GeometryInputType, (int, string)> _primitiveInputs = new Dictionary<GeometryInputType, (int, string)>()
//        {
//            [GeometryInputType.Point] = (1, "point"),
//            [GeometryInputType.Line] = (2, "line"),
//            [GeometryInputType.Triangle] = (3, "triangle"),
//            [GeometryInputType.LineWithAdjacency] = (4, "lineadj"),
//            [GeometryInputType.TriangleWithAdjacency] = (6, "triangleadj")
//        };

//        public string TranslateHeader(ShaderContext context, EntryPoint ep, MethodInformation info)
//        {
//            SeparatedSyntaxList<AttributeArgumentSyntax> args = ep.AttributeSyntax.ArgumentList.Arguments;
//            string result = "";

//            if (args.Count > 1)
//            {
//                string strInputType = args[0].ToString().Replace($"{nameof(GeometryInputType)}.", "");

//                if (Enum.TryParse(strInputType, out GeometryInputType inputType))
//                {
//                    // Second argument is the output vertex count
//                    string strVertexOutCount = args[1].ToString();

//                    if (int.TryParse(strVertexOutCount, out int vertexOutCount) && vertexOutCount > 0)
//                    {
//                        (int inputSize, string strInputName) = _primitiveInputs[inputType];
//                        result += $"[maxvertexcount({vertexOutCount})]{Environment.NewLine}";

//                        string strParameters = "";
//                        foreach (ParameterSyntax p in info.Syntax.ParameterList.Parameters)
//                        {
//                            if (strParameters.Length > 0)
//                                strParameters += ", ";

//                            TypeSyntax typeSyntax = p.Type;
//                            if (p.Type is ArrayTypeSyntax arraySyntax)
//                                typeSyntax = arraySyntax.ElementType;

//                            if (context.Structures.ContainsKey(typeSyntax.ToString()))
//                                strParameters += $"{strInputName} {typeSyntax} {p.Identifier}[{inputSize}]";
//                            else
//                                strParameters += $"inout {typeSyntax} {p.Identifier}";
//                        }

//                        result += $"void {info.Identifier}({strParameters})";
//                    }
//                    else
//                    {
//                        context.Parent.AddMessage($"Invalid GeometryShader max vertex output count. Expected a value greater than 0. Got: {strVertexOutCount}", 0, 0);
//                    }
//                }
//                else
//                {
//                    context.Parent.AddMessage($"Invalid geometry input type: {strInputType}. Expected a valid {nameof(GeometryInputType)} value. Got: {strInputType}.", 0, 0);
//                }
//            }

//            return result;
//        }
//    }
//}
