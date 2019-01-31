using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Languages.HLSL.Translators
{
    internal class HullTranslator : DefaultEntryPointTranslator
    {
        static readonly Dictionary<HullPartitioning, string> _partitionNames = new Dictionary<HullPartitioning, string>()
        {
            [HullPartitioning.Integer] = "integer",
            [HullPartitioning.FractionalEven] = "fractional_even",
            [HullPartitioning.FractionalOdd] = "fractional_odd",
            [HullPartitioning.PowerOfTwo] = "pow2",
        };

        static readonly Dictionary<HullOutputTopology, string> _topologyNames = new Dictionary<HullOutputTopology, string>()
        {
            [HullOutputTopology.Line] = "line",
            [HullOutputTopology.Point] = "point",
            [HullOutputTopology.TriangleCCW] = "triangle_ccw",
            [HullOutputTopology.TriangleCW] = "triangle_cw",
        };

        public override void TranslatePrefix(ShaderContext sc, MethodInfo info, MethodDeclarationSyntax syntax, EntryPoint ep)
        {
            HullShaderAttribute attHull = ep.Attribute as HullShaderAttribute;
            string patchType = attHull.PatchType.ToString().ToLower();
            sc.Source.Append($"[domain(\"{patchType}\")]");
            sc.Source.AppendLineBreak();

            string partType = _partitionNames[attHull.Partitioning];
            sc.Source.Append($"[partitioning(\"{partType}\")]");
            sc.Source.AppendLineBreak();

            string topology = _topologyNames[attHull.Topology];
            sc.Source.Append($"[outputtopology(\"{topology}\")]");
            sc.Source.AppendLineBreak();

            sc.Source.Append($"[outputcontrolpoints({attHull.OutputControlPoints})]");
            sc.Source.AppendLineBreak();

            sc.Source.Append($"[patchconstantfunc(\"{attHull.PatchConstantCallback}\")]");
            sc.Source.AppendLineBreak();
        }
    }
}
