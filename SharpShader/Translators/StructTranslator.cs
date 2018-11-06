using System.IO;

namespace SharpShader
{
    internal class StructTranslator : Translator
    {
        internal override void Translate(ConversionContext context)
        {
            foreach (ShaderStructure s in context.Structures)
            {
                string structure = s.Syntax.ToString();

                structure = Strip.Accessors(structure) + ";";
                structure = Strip.CorrectIndents(structure, 0);
                context.WriteLine(structure);
                context.WriteLine();
            }
        }
    }
}