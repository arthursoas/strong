using System;
using System.Linq;

namespace Strong
{
    public static class Casing
    {
        /// <summary>
        /// Converts a string in snake_case to a string in camelCase
        /// </summary>
        /// <param name="str">Snake case string</param>
        /// <returns>Camel case string</returns>
        public static string FromSnakeCaseToCamelCase(this string str)
        {
            var pascalCase = str.FromSnakeCaseToPascalCase();
                
            return $"{pascalCase.Substring(0, 1).ToLower()}{pascalCase.Substring(1)}";
        }

        /// <summary>
        /// Converts a string in snake_case to a string in PascalCase
        /// </summary>
        /// <param name="str">Snake case string</param>
        /// <returns>Pascal case string</returns>
        public static string FromSnakeCaseToPascalCase(this string str)
        {
            return str
                .ToLowerInvariant()
                .Split('_', StringSplitOptions.RemoveEmptyEntries)
                .Select(subStr => $"{subStr.Substring(0, 1).ToUpper()}{subStr.Substring(1)}")
                .Aggregate((subStrA, subStrB) => $"{subStrA}{subStrB}");
        }

        /// <summary>
        /// Converts a string in snake_case to a string in kebab-case
        /// </summary>
        /// <param name="str">Snake case string</param>
        /// <returns>Kebab case string</returns>
        public static string FromSnakeCaseToKebabCase(this string str)
        {
            return str;
        }

        public static string FromCamelCaseToSnakeCase(this string str)
        {
            return str;
        }

        public static string FromCamelCaseToPascalCase(this string str)
        {
            return str;
        }

        public static string FromCamelCaseToKebabCase(this string str)
        {
            return str;
        }
    }
}
