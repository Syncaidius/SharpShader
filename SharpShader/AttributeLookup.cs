using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{

    internal class AttributeLookup
    {
        Dictionary<Type, List<AttributeSyntax>> _byType;

        SyntaxList<AttributeListSyntax> _syntax;

        internal AttributeLookup(SyntaxList<AttributeListSyntax> attributes)
        {
            _syntax = attributes;
            _byType = new Dictionary<Type, List<AttributeSyntax>>();

            foreach (AttributeListSyntax list in attributes)
            {
                foreach (AttributeSyntax att in list.Attributes)
                {
                    string attName = att.Name.ToString();
                    if (!attName.EndsWith("Attribute"))
                        attName += "Attribute";

                    Type t = ReflectionHelper.ResolveType(attName);
                    if (t != null)
                    {
                        List<AttributeSyntax> attList = null;
                        if (!_byType.TryGetValue(t, out attList))
                        {
                            attList = new List<AttributeSyntax>();
                            _byType.Add(t, attList);
                        }

                        attList.Add(att);
                    }
                }
            }
        }

        /// <summary>
        /// Attempts to retrieve the first occurrence of an attribute.
        /// </summary>
        /// <typeparam name="T">The type of attribute.</typeparam>
        /// <param name="attSyntax">The destination for the retrieved attribute syntax node, if successful.</param>
        /// <returns></returns>
        internal bool TryGetAttribute<T>(out AttributeSyntax attSyntax) where T : Attribute
        {
            if (_byType.TryGetValue(typeof(T), out List<AttributeSyntax> attList))
            {
                attSyntax = attList[0];
                return true;
            }

            attSyntax = null;
            return false;
        }

        /// <summary>
        /// Returns a list containing all occurrences of the specified attribute, or null if none were found.
        /// </summary>
        /// <typeparam name="T">The type of attribute.</typeparam>
        /// <returns></returns>
        internal List<AttributeSyntax> GetAttributes<T>() where T : Attribute
        {
            List<AttributeSyntax> attList = null;
            _byType.TryGetValue(typeof(T), out attList);
            return attList;
        }

        public override string ToString()
        {
            return _syntax.ToString();
        }
    }
}
