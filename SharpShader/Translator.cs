using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Emit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
        TranslationRunner _runner;

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
        public TranslationResult Translate(string fileOrFriendlyName, string cSharpSource, OutputLanguage outputLanguage, TranslationFlags flags = TranslationFlags.None, List<string> preprocessorSymbols = null)
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
        public TranslationResult Translate(Dictionary<string, string> cSharpSources,
            OutputLanguage outputLanguage,
            TranslationFlags flags = TranslationFlags.None,
            List<string> preprocessorSymbols = null)
        {
            if (_disposed)
                throw new ObjectDisposedException("Translator instance has been disposed.");

            TranslationArgs tArgs = new TranslationArgs()
            {
                CSharpSources = new Dictionary<string, string>(cSharpSources),
                Flags = flags,
                Language = outputLanguage,
                PreprocessorSymbols = preprocessorSymbols ?? new List<string>(),
            };

            TranslationContext context = _runner.Run(tArgs);
            TranslationResult result = BuildResult(context, flags);

            context.Recycle();
            return result;
        }

        private TranslationResult BuildResult(TranslationContext context, TranslationFlags flags)
        {
            var msg = new List<TranslationMessage>(context.Messages);
            var output = new Dictionary<string, ShaderTranslationResult>();

            foreach (ShaderTranslationContext sc in context.Shaders)
            {
                var cBuffers = new List<ConstantBufferInfo>();
                var includes = new Dictionary<string, ShaderTranslationResult>();
                var variables = new List<ShaderMember>();

                foreach (KeyValuePair<string, MappedConstantBuffer> p in sc.ConstantBuffers)
                {
                    List<ShaderMember> cBufferVariables = new List<ShaderMember>();

                    foreach (MappedField mField in p.Value.Variables)
                        cBufferVariables.Add(PopulateMember(mField));

                    cBuffers.Add(new ConstantBufferInfo(p.Key, cBufferVariables, p.Value.BindSlots));
                }

                foreach (MappedField mField in sc.MappedFields)
                    variables.Add(PopulateMember(mField));

                /* TODO:
                 *  - Produce info for a SINGLE entry point
                 *  - If a ShaderResult is used as an include, flag a boolean property as such (e.g. IsInclude).
                 *  - Produce input and output layout information (ShaderInputOuput).
                 */


                string strSourceResult = sc.Source.ToString();

                if ((flags & TranslationFlags.SkipFormatting) != TranslationFlags.SkipFormatting)
                {
                    if ((flags & TranslationFlags.RemoveWhitespace) == TranslationFlags.RemoveWhitespace)
                        FormattingHelper.RemoveWhitespace(ref strSourceResult, flags);
                    else
                        FormattingHelper.CorrectIndents(ref strSourceResult, flags);
                }
                ShaderTranslationResult shader = new ShaderTranslationResult(sc.Namespace, strSourceResult, includes, cBuffers, variables);
                output.Add(sc.Name, shader);
            }

            return new TranslationResult(msg, output);
        }

        private ShaderMember PopulateMember(MappedField mField)
        {
            ShaderElementInfo eInfo = new ShaderElementInfo(
                dataType: mField.Type.DataType,
                dimensions: new List<int>(mField.Type.Dimensions),
                size: mField.Type.SizeOf,
                subElementCount: mField.Type.SubElementCount,
                subElementSize: mField.Type.SubElementSizeOf,
                strucType: mField.StructureType
            );

            return new ShaderMember(
                name: mField.Name,
                arrayDimensions: new List<int>(mField.ArrayDimensions),
                elementCount: mField.GetTotalArrayElements(),
                startOffset: mField.PackOffsetBytes.HasValue ? mField.PackOffsetBytes.Value : 0,
                elementInfo: eInfo,
                sizeOf: mField.GetTotalSizeOf(),
                resType: mField.ResourceType,
                resBaseType: mField.ResourceBaseType
            );
        }

        /// <summary>
        /// Disposes the current <see cref="Translator"/> and unloads it's app domain.
        /// </summary>
        public void Dispose()
        {
            if (_disposed)
                return;

            _disposed = true;
            _runner.Dispose();
            AppDomain.Unload(_domain);
            _domain = null;
        }

        private void SpawnDomain()
        {
            int id = Interlocked.Increment(ref _nextDomainID);
            _domain = AppDomain.CreateDomain($"{_domainName}_{id}");

            foreach (ShaderType.SupportedNamespace sn in ShaderType.SupportedNamespaces)
            {
                foreach(AssemblyName aName in sn.Assemblies)
                    _domain.Load(aName);
            }

            Type t = typeof(TranslationRunner);
            _runner = (TranslationRunner)_domain.CreateInstanceAndUnwrap(t.Assembly.FullName, t.FullName, false, 
                BindingFlags.NonPublic | BindingFlags.Instance, null, null, CultureInfo.InvariantCulture, null);
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
