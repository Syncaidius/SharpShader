using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal abstract partial class ShaderLanguage
    {
        internal class Modifier
        {
            /// <summary>
            /// A list containing the C# modifiers required for this native translation to be accepted.
            /// </summary>
            internal List<string> Requirements = new List<string>();

            /// <summary>
            /// The modifier in it's native language (e.g. const static).
            /// </summary>
            internal string NativeText;

            internal bool IsMatch(SyntaxTokenList csharpModifiers)
            {
                if (csharpModifiers.Count != Requirements.Count)
                    return false;

                // The syntax token list must contain each of the requirements. 
                // If one is not found, we return false.
                foreach (string s in Requirements)
                {
                    bool found = false;
                    foreach (SyntaxToken t in csharpModifiers)
                    {
                        if (t.ToString() == s)
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                        return false;
                }

                return true;
            }

            public override string ToString()
            {
                return NativeText;
            }
        }
    }
}
