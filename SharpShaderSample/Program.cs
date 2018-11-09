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
            string output = "";

            using(FileStream fs = new FileStream("SampleShader.cs", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    string csharp = reader.ReadToEnd();
                    output = converter.Convert(csharp, ShaderLanguage.HLSL);
                }
            }

            using (FileStream fs = new FileStream("SampleShader.hlsl", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write(output);
                }
            }

            Console.ReadKey();
        }
    }
}
