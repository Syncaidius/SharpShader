using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal partial class TranslationContext : MarshalByRefObject
    {
        internal class ReflectionInfo
        {
            internal List<Type> ShaderTypes { get; private set; }

            Assembly _assembly;

            internal Assembly Assembly
            {
                get => _assembly;
                set
                {
                    if (_assembly != value)
                    {
                        _assembly = value;
                        ShaderTypes = FindOfType<CSharpShader>().ToList();
                    }
                }
            }

            internal bool IsShaderType(Type t)
            {
                return ShaderTypes.IndexOf(t) > -1;
            }

            /// <summary>
            /// Finds all types which are a sub-class of the specified type and not abstract, in the current <see cref="Assembly"/>.
            /// </summary>
            /// <typeparam name="T">The type of which to find sub-classes.</typeparam>
            /// <returns></returns>
            internal IEnumerable<Type> FindOfType<T>() where T : class
            {
                Type pType = typeof(T);
                IEnumerable<Type> test = _assembly.GetTypes();
                return _assembly.GetTypes().Where(t => t.IsSubclassOf(pType) && !t.IsAbstract);
            }
        }
    }
}
