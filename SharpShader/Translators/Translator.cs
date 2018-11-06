using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal abstract class Translator
    {
        internal abstract void Translate(ConversionContext context);
    }
}
