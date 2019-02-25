using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// Specifies the register or slot ID for a field or constant buffer structure. <para/>
    /// Multiple register attributes can be used to specify different slots for different stages of the shader pipeline, on the same object.
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Field, AllowMultiple = true)]
    public class RegisterAttribute : SharpShaderAttribute
    {
        /// <summary>
        /// Gets the register or slot ID.
        /// </summary>
        public uint Slot { get; }

        /// <summary>
        /// The shader model to use if <see cref="ApplicableEntryPoint"/> is set to a value greater than <see cref="EntryPointType.AnyOrNone"/>. The default value is <see cref="ShaderModel.SM_5_0"/>.
        /// </summary>
        public ShaderModel Model { get; }

        /// <summary>
        /// The shader profile/stage that the register binding applies to.
        /// </summary>
        public EntryPointType ApplicableEntryPoint { get; }

        /// <summary>
        /// Creates a new instance of <see cref="RegisterAttribute"/>.
        /// </summary>
        /// <param name="slot"></param>
        /// <param name="entryPoint">The target shader profile of the register.</param>
        /// <param name="model">The target shader model of the register.</param>
        public RegisterAttribute(uint slot, EntryPointType entryPoint = EntryPointType.AnyOrNone, ShaderModel model = ShaderModel.SM_5_0)
        {
            Slot = slot;
            Model = ShaderModel.SM_5_0;
            ApplicableEntryPoint = EntryPointType.AnyOrNone;
        }
    }

    /// <summary>
    /// Used for tagging types as compatible with <see cref="RegisterAttribute"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, Inherited = true)]
    internal class RegisteredTypeAttribute : SharpShaderAttribute { }
}
