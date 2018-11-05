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
            using(FileStream fs = new FileStream("SampleShader.cs", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    string csharp = reader.ReadToEnd();
                    string output = converter.Convert(csharp, ShaderOutput.HLSL);
                }
            }

            Console.ReadKey();
        }
    }
}
