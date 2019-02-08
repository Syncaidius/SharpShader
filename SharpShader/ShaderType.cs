using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// Provides type information for a shader language-specific type.
    /// </summary>
    internal class ShaderType
    {
        /// <summary>
        /// Gets the translated name of the current <see cref="ShaderType"/>
        /// </summary>
        internal string Translation { get; }

        internal Type OriginalType { get; }

        internal int SizeOf { get; }

        internal int TypeID { get; }

        static int _nextTypeID;

        public bool IsRegisteredType { get; }

        public bool IsUnorderedAccessType { get; }

        internal ShaderType(string translation, Type originalType)
        {
            TypeID = Interlocked.Increment(ref _nextTypeID);

            object[] attributes = originalType.GetCustomAttributes(typeof(RegisteredTypeAttribute), false);
            IsRegisteredType = attributes.Length > 0;

            attributes = originalType.GetCustomAttributes(typeof(UnorderedAccessTypeAttribute), false);
            IsUnorderedAccessType = attributes.Length > 0;

            OriginalType = originalType;
            Translation = translation;
        }
    }
}
