using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyUtils.DebuggerVisualizers.Internal
{
    public static class ReflectionExtensions
    {
        private static readonly string[] wellKnownNamespaces = new string[]
        {
            "System", "System.Collections",
            "System.Collections.Generic",
        };

        private static readonly Dictionary<Type, string> typeAliasMap = new Dictionary<Type, string>
        {
            { typeof(bool), "bool" },
            { typeof(byte), "byte" },
            { typeof(sbyte), "sbyte" },
            { typeof(char), "char" },
            { typeof(decimal), "decimal" },
            { typeof(double), "double" },
            { typeof(float), "float" },
            { typeof(int    ), "int" },
            { typeof(uint), "uint" },
            { typeof(long), "long" },
            { typeof(ulong), "ulong" },
            { typeof(object), "object" },
            { typeof(short), "short" },
            { typeof(ushort), "ushort" },
            { typeof(string), "string" },
        };

        public static string GetCSharpType(this Type self)
        {
            if (typeAliasMap.ContainsKey(self))
            {
                return typeAliasMap[self];
            }

            if (!self.IsGenericType)
            {
                return IsWellKnownNamesapce(self) ? self.Name : self.FullName;
            }

            if (self.Name.StartsWith("<>f__AnonymousType"))
            {
                return "'a";
            }

            var genericTypeName = IsWellKnownNamesapce(self) ? self.Name.Split('`')[0] : self.FullName.Split('`')[0];
            return string.Format(
                "{0}<{1}>",
                genericTypeName,
                string.Join(", ", self.GetGenericArguments().Select(c => c.GetCSharpType())));

            bool IsWellKnownNamesapce(Type t)
            {
                return wellKnownNamespaces.Contains(t.Namespace);
            }
        }
    }
}