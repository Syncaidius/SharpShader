using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal static class FormattingHelper
    {
        static readonly string[] _delimiters = { Environment.NewLine };
        const string BlockOpen = "{";
        const string BlockClosed = "}";

        /// <summary>
        /// Strips and re-adds the correct amount of indentation to a code string.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="minIndent">The minimum level of indentation.</param>
        /// <returns></returns>
        internal static void CorrectIndents(ref string target, ConversionFlags flags)
        {
            string[] lines = target.Trim().Split(_delimiters, StringSplitOptions.None);
            int indent = 0;
            bool prevLineEmpty = false;
            int newLineCount = lines.Length;

            for (int i = 0; i < newLineCount; i++)
            {
                lines[i] = lines[i].Trim().Replace("  ", " ");


                // Remove consecutive empty lines.
                bool curLineEmpty = string.IsNullOrWhiteSpace(lines[i]);
                int cPos = i + 1;
                if (prevLineEmpty && curLineEmpty && cPos < lines.Length)
                {
                    Array.Copy(lines, cPos, lines, i, lines.Length - cPos);
                    i--;
                    newLineCount--;
                    continue;
                }

                // TODO improve this later. It's fugly!
                bool blockStarted = lines[i].StartsWith(BlockOpen) || lines[i].EndsWith(BlockOpen);
                bool blockEnded = lines[i].EndsWith(BlockClosed) ||
                    lines[i].EndsWith(BlockClosed + ";") ||
                    lines[i].StartsWith(BlockClosed + "//") ||
                    lines[i].StartsWith(BlockClosed + " //");

                if (lines[i].StartsWith(BlockClosed) && blockEnded)
                    indent = Math.Max(indent - 1, 0);


                lines[i] = new string('\t', indent) + lines[i];
                if (lines[i].StartsWith("//"))
                {
                    if ((flags & ConversionFlags.StripComments) == ConversionFlags.StripComments)
                        lines[i] = "";
                }

                if (blockStarted && !blockEnded)
                    indent++;

                prevLineEmpty = curLineEmpty;
            }

            target = string.Join(Environment.NewLine, lines, 0, newLineCount);
        }

        internal static void RemoveWhitespace(ref string target, ConversionFlags flags)
        {
            string[] lines = target.Trim().Split(_delimiters, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
            {
                // TODO check if the output language supports comment blocks. If not, add a line break to the end of the comment.
                lines[i] = lines[i].Trim();
                if (lines[i].StartsWith("//"))
                {
                    if ((flags & ConversionFlags.StripComments) == ConversionFlags.StripComments)
                        lines[i] = "";
                    else
                        lines[i] = $"/* {lines[i]} */";
                }
            }

            target = string.Join("", lines);
        }
    }
}
