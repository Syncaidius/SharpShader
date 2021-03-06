﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal static class Pooling
    {
        internal static readonly ObjectPool<TranslationContext> Contexts = new ObjectPool<TranslationContext>();

        internal static readonly ObjectPool<ShaderTranslationContext> ShaderContexts = new ObjectPool<ShaderTranslationContext>();

        internal static readonly ObjectPool<ScopeInfo> Scopes = new ObjectPool<ScopeInfo>();

        internal static ObjectPool<MappedField> MappedFields = new ObjectPool<MappedField>();

        internal static ObjectPool<MappedConstantBuffer> MappedConstBuffers = new ObjectPool<MappedConstantBuffer>();

        internal static ObjectPool<MethodBucket> MethodBuckets = new ObjectPool<MethodBucket>();

        internal static ObjectPool<SourceSegment> SourceSegments = new ObjectPool<SourceSegment>();
    }
}
