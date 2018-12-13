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
            Converter converter = new Converter();
            ConversionResult output = null;

            using(FileStream fs = new FileStream("SampleShader.cs", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    Dictionary<string, string> input = new Dictionary<string, string>()
                    {
                        ["SampleShader"] = reader.ReadToEnd(),
                    };
                    output = converter.Convert(input, ShaderLanguage.HLSL);
                }
            }

            // Store the output to file so we can take a look at it ourselves.
            if (output != null)
            {
                foreach (KeyValuePair<string, ShaderResult> kvp in output)
                {
                    using (FileStream fs = new FileStream($"{kvp.Key}.hlsl", FileMode.Create, FileAccess.Write))
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
