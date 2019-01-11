using Microsoft.CodeAnalysis;
using SharpShader.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [Serializable]
    internal class OutputSource
    {
        const char STR_OPEN_BLOCK = '{';
        const char STR_CLOSE_BLOCK = '}';

        StringBuilder _sb = new StringBuilder();

        [NonSerialized]
        int _blockScopeDepth = 0;

        internal void Append(string src)
        {
            _sb.Append(src);
        }

        internal void OpenBlock()
        {
            _blockScopeDepth++;
            _sb.Append(STR_OPEN_BLOCK);
        }

        internal void CloseBlock()
        {
            if (_blockScopeDepth == 0)
                throw new BlockScopeException("Cannot close block. No blocks left to close.");

            _blockScopeDepth--;
            _sb.Append(STR_CLOSE_BLOCK);
        }

        internal void Insert(string src, int index)
        {
            _sb.Insert(index, src);
        }

        public override string ToString()
        {
            return _sb.ToString();
        }
    }
}
