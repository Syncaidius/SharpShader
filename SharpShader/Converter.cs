using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Emit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// Converts C# source code into shader language code.
    /// </summary>
    public class Converter
    {
        #region Instance members
        /// <summary>
        /// Converts the provided C# source code to the specified shader language.
        /// </summary>
        /// <param name="fileOrFriendlyName">The filename or friendly name to assign to the source code.</param>
        /// <param name="cSharpSource">The C# source code to be converted.</param>
        /// <param name="outputLanguage">The output shader language.</param>
        /// <param name="flags">A set of flags to change the default behaviour of the converter.</param>
        /// <param name="preprocessorSymbols">A list of defined preprocessor symbols.</param>
        /// <returns></returns>
        public ConversionResult Convert(string fileOrFriendlyName, string cSharpSource, OutputLanguage outputLanguage, ConversionFlags flags = ConversionFlags.None, List<string> preprocessorSymbols = null)
        {
            return Convert(new Dictionary<string, string>()
            {
                [fileOrFriendlyName] = cSharpSource,
            }, 
            outputLanguage, flags);
        }

        /// <summary>
        /// Converts the provided C# source code to the specified shader language.
        /// </summary>
        /// <param name="cSharpSources">A dictionary containing source code by file or friendly name.</param>
        /// <param name="outputLanguage">The language that the input source code should be translated to.</param>
        /// <param name="flags">A set of flags to change the default behaviour of the converter.</param>
        /// <param name="preprocessorSymbols">A list of defined preprocessor symbols.</param>
        /// <returns></returns>
        public ConversionResult Convert(Dictionary<string, string> cSharpSources, OutputLanguage outputLanguage, ConversionFlags flags = ConversionFlags.None, List<string> preprocessorSymbols = null)
        {
            AppDomain domain = AppDomain.CreateDomain("SharpShader");
            foreach(AssemblyName an in ReflectionHelper.SupportedAssemblies)
                domain.Load(an);
            TranslationArgs tArgs = new TranslationArgs()
            {
                CSharpSources = new Dictionary<string, string>(cSharpSources),
                Flags = flags,
                Language = outputLanguage,
                PreprocessorSymbols = preprocessorSymbols,
            };

            TranslationRunner runner = (TranslationRunner)domain.CreateInstanceAndUnwrap(typeof(TranslationRunner).Assembly.FullName, typeof(TranslationRunner).FullName);
            ConversionContext context = runner.Run(tArgs);
            ConversionResult result = new ConversionResult(context, flags);
            AppDomain.Unload(domain);

            return result;
        }
        #endregion
    }
}
