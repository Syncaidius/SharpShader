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
                //"FunctionalityTestShader.cs",
                //"SampleShader.cs",
                "SampleTextureShader.cs",
                //"SampleSpriteShader.cs"
            };

            Converter converter = new Converter();
            ConversionResult output = null;
            ShaderLanguage language = ShaderLanguage.HLSL;

            foreach(string fn in samples)
            {
                string title = $"Translating {fn}";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(title);
                Console.WriteLine(new string('=', title.Length));
                Console.ForegroundColor = ConsoleColor.White;

                FileInfo fInfo = new FileInfo(fn);

                using (FileStream fs = new FileStream(fn, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        Dictionary<string, string> input = new Dictionary<string, string>()
                        {
                            [fInfo.Name] = reader.ReadToEnd(),
                        };
                        output = converter.Convert(input, language);
                    }
                }

                // Store the output to file so we can take a look at it ourselves.
                if (output != null)
                {
                    foreach (KeyValuePair<string, ShaderResult> kvp in output)
                    {
                        using (FileStream fs = new FileStream($"{fInfo.FullName}.{language.ToString().ToLower()}", FileMode.Create, FileAccess.Write))
                        {
                            using (StreamWriter writer = new StreamWriter(fs))
                            {
                                writer.Write(kvp.Value.SourceCode);
                            }
                        }
                    }
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
