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
        internal EntryPointType EntryType;

        [NonSerialized]
        internal EntryPointAttribute Attribute;

        [NonSerialized]
        internal IEntryPointTranslator Translator;

        public int StartIndex { get; set; }

        public int EndIndex { get; set; }

        internal MappedEntryPoint(IEntryPointTranslator translator, EntryPointAttribute attribute)
        {
            Attribute = attribute;
            EntryType = attribute.EntryType;
            Translator = translator;
        }

        public override string ToString()
        {
            return EntryType.ToString();
        }
    }
}
