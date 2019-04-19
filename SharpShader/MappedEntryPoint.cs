using SharpShader.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [Serializable]
    internal class MappedEntryPoint : ISegmentTracker
    {
        [NonSerialized]
        internal EntryPointAttribute Attribute;

        [NonSerialized]
        internal IEntryPointTranslator Translator;

        public EntryPointInfo Info;

        public int StartIndex
        {
            get => Info.StartIndex;
            set => Info.StartIndex = value;
        }

        public int EndIndex
        {
            get => Info.EndIndex;
            set => Info.EndIndex = value;
        }

        internal MappedEntryPoint(string name, IEntryPointTranslator translator, EntryPointAttribute attribute)
        {
            Attribute = attribute;
            Translator = translator;
            Info = new EntryPointInfo()
            {
                Name = name,
                Type = attribute.EntryType,
            };

            switch (attribute)
            {
                case ComputeShaderAttribute epCompute:
                    Info.ThreadGroupSize = new Int3(epCompute.ThreadsX, epCompute.ThreadsY, epCompute.ThreadsZ);
                    break;

                case DomainShaderAttribute epDomain:
                    Info.PatchType = epDomain.PatchType;
                    break;

                case HullShaderAttribute epHull:
                    Info.PatchType = epHull.PatchType;
                    Info.HullControlPoints = epHull.OutputControlPoints;
                    Info.HullTopology = epHull.Topology;
                    Info.HullPartitioning = epHull.Partitioning;
                    Info.HullPatchConstantCallback = epHull.PatchConstantCallback;
                    break;

                case GeometryShaderAttribute epGeo:
                    Info.GeometryType = epGeo.InputType;
                    Info.GeometryMaxVertexOut = epGeo.MaxVertexOutCount;
                    break;
            }
        }

        public override string ToString()
        {
            return Info.Type.ToString();
        }
    }
}
