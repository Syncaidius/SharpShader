using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Field, AllowMultiple = true)]
    public class RegisterAttribute : SharpShaderAttribute
    {
        public uint Slot { get; }

        /// <summary>
        /// The shader model to use if <see cref="ApplicableEntryPoint"/> is set to a value greater than <see cref="EntryPointType.AnyOrNone"/>. The default value is <see cref="ShaderModel.SM_5_0"/>.
        /// </summary>
        public ShaderModel Model { get; }

        /// <summary>
        /// The shader profile/stage that the register binding applies to.
        /// </summary>
        public EntryPointType ApplicableEntryPoint { get; }

        public RegisterAttribute(uint slot, EntryPointType entryPoint = EntryPointType.AnyOrNone, ShaderModel model = ShaderModel.SM_5_0)
        {
            Slot = slot;
            Model = ShaderModel.SM_5_0;
            ApplicableEntryPoint = EntryPointType.AnyOrNone;
        }

        internal static uint? Parse(AttributeSyntax syntax)
        {
            uint? register = null;
            if (syntax.ArgumentList.Arguments.Count > 0)
            {
                if (uint.TryParse(syntax.ArgumentList.Arguments[0].ToString(), out uint val))
                    register = val;
            }

            return register;
        }
    }

    /// <summary>
    /// Used for tagging types as compatible with <see cref="RegisterAttribute"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    internal class RegisteredTypeAttribute : SharpShaderAttribute { }
}
