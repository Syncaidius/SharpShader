using SharpShader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShaderSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] samples = {
                "FunctionalityTestShader.cs",
                //"SampleShader.cs",
                //"SampleTextureShader.cs",
                //"MoltenSpriteShader.cs"
            };

            Converter converter = new Converter();
            ConversionResult output = null;
            OutputLanguage language = OutputLanguage.HLSL;

            // Load all of the sources into a dictionary,
            // so that all of them can be translated in a single converter.Convert() call.
            Dictionary<string, string> sources = new Dictionary<string, string>();
            foreach (string fn in samples)
            {
                Console.WriteLine($"Reading {fn}");

                FileInfo fInfo = new FileInfo(fn);
                string strInput = File.ReadAllText(fn);
                sources.Add(fn, strInput);
            }

            output = converter.Convert(sources, language);

            // Store the output to file so we can take a look at it ourselves.
            if (output != null)
            {
                string langExtension = $"{language.ToString().ToLower()}";

                foreach (KeyValuePair<string, ShaderResult> kvp in output)
                {
                    using (FileStream fs = new FileStream($"{kvp.Key}.{langExtension}", FileMode.Create, FileAccess.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(fs))
                        {
                            writer.Write(kvp.Value.SourceCode);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
