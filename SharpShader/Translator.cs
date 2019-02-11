using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Emit;
using SharpShader.Result;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// Converts C# source code into shader language code.
    /// </summary>
    public class Translator : IDisposable
    {
        #region Instance members

        /// <summary>
        /// The default name for The converter's <see cref="AppDomain"/>.
        /// </summary>
        public const string DEFAULT_APP_DOMAIN = "Sharp Shader";

        static int _nextDomainID;
        AppDomain _domain;
        string _domainName;
        bool _disposed;

        /// <summary>
        /// Creates a new instance of <see cref="Translator"/>..
        /// </summary>
        /// <param name="appDomainName">The name to give to the translator's app domain.</param>
        public Translator(string appDomainName = DEFAULT_APP_DOMAIN)
        {
            _domainName = appDomainName;
            SpawnDomain();
        }

        /// <summary>
        /// Converts the provided C# source code to the specified shader language.
        /// </summary>
        /// <param name="fileOrFriendlyName">The filename or friendly name to assign to the source code.</param>
        /// <param name="cSharpSource">The C# source code to be converted.</param>
        /// <param name="outputLanguage">The output shader language.</param>
        /// <param name="flags">A set of flags to change the default behaviour of the converter.</param>
        /// <param name="preprocessorSymbols">A list of defined preprocessor symbols.</param>
        /// <returns></returns>
        public TranslationResult Convert(string fileOrFriendlyName, string cSharpSource, OutputLanguage outputLanguage, ConversionFlags flags = ConversionFlags.None, List<string> preprocessorSymbols = null)
        {
            return Translate(new Dictionary<string, string>()
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
        public TranslationResult Translate(Dictionary<string, string> cSharpSources, OutputLanguage outputLanguage, ConversionFlags flags = ConversionFlags.None, List<string> preprocessorSymbols = null)
        {
            if (_disposed)
                throw new ObjectDisposedException("Translator instance has been disposed.");

            foreach(AssemblyName an in ShaderType.SupportedAssemblies)
                _domain.Load(an);
            TranslationArgs tArgs = new TranslationArgs()
            {
                CSharpSources = new Dictionary<string, string>(cSharpSources),
                Flags = flags,
                Language = outputLanguage,
                PreprocessorSymbols = preprocessorSymbols,
            };

            Type t = typeof(TranslationRunner);
            TranslationRunner runner = (TranslationRunner)_domain.CreateInstanceAndUnwrap(t.Assembly.FullName, t.FullName);
            TranslationContext context = runner.Run(tArgs);
            TranslationResult result = new TranslationResult(context, flags);

            context.Recycle();
            return result;
        }

        /// <summary>
        /// Disposes the current <see cref="Translator"/> and unloads it's app domain.
        /// </summary>
        public void Dispose()
        {
            if (_disposed)
                return;

            _disposed = true;
            AppDomain.Unload(_domain);
            _domain = null;
        }

        private void SpawnDomain()
        {
            int id = Interlocked.Increment(ref _nextDomainID);
            _domain = AppDomain.CreateDomain($"{_domainName}_{id}");
        }

        /// <summary>
        /// Reloads the translator and it's app domain. 
        /// </summary>
        public void Reload()
        {
            AppDomain.Unload(_domain);
            SpawnDomain();
        }

        /// <summary>
        /// Gets whether or not the current <see cref="Translator"/> instance has been disposed.
        /// </summary>
        public bool IsDisposed => _disposed;

        #endregion
    }
}
