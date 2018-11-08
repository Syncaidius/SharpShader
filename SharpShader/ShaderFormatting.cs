using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A helper class for stripping various parts of C# code.
    /// </summary>
    public static class ShaderFormatting
    {
        static readonly string[] _accessorWords = { "protected", "private", "public", "internal", "override", "sealed", "virtual" };
        static readonly string[] _delimiters = { Environment.NewLine };
        const string BlockOpen = "{";
        const string BlockClosed = "}";

        /// <summary>
        /// Strips and re-adds the correct amount of indentation to a code string.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="minIndent">The minimum level of indentation.</param>
        /// <returns></returns>
        public static string CorrectIndents(string input)
        {
            string[] lines = input.Split(_delimiters, StringSplitOptions.None);
            int indent = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Trim();

                bool blockStarted = lines[i].StartsWith(BlockOpen);
                bool blockEnded = lines[i].EndsWith(BlockClosed) || lines[i].EndsWith(BlockClosed + ";");

                if (lines[i].StartsWith(BlockClosed) && blockEnded)
                    indent = Math.Max(indent - 1, 0);

                lines[i] = new string('\t', indent) + lines[i];

                if (blockStarted && !blockEnded)
                    indent++;
            }

            return string.Join(Environment.NewLine, lines);
        }
    }
}
