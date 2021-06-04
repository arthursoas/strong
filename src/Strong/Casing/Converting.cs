using System;
using System.Linq;

namespace Strong.Casing
{
    public static class Converting
    {
        /// <summary>
        /// Converts a string in snake_case to a string in camelCase
        /// </summary>
        /// <param name="str">Snake case string</param>
        /// <returns>Camel case string</returns>
        public static string FromSnakeCaseToCamelCase(this string str)
        {
            ThrowIfHasWhiteSpace(str);
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
            ThrowIfHasWhiteSpace(str);

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
            ThrowIfHasWhiteSpace(str);

            return str
                .ToLowerInvariant()
                .Split('_', StringSplitOptions.RemoveEmptyEntries)
                .Aggregate((subStrA, subStrB) => $"{subStrA}-{subStrB}");
        }

        /// <summary>
        /// Converts a string in camelCase to a string in snake_case
        /// </summary>
        /// <param name="str">Camel case string</param>
        /// <returns>Snake case string</returns>
        public static string FromCamelCaseToSnakeCase(this string str)
        {
            ThrowIfHasWhiteSpace(str);

            return str
                .SplitCamelCase()
                .Aggregate((subStrA, subStrB) => $"{subStrA}_{subStrB}")
                .ToLowerInvariant();
        }

        /// <summary>
        /// Converts a string in camelCase to a string in PascalCase
        /// </summary>
        /// <param name="str">Camel case string</param>
        /// <returns>Pascal case string</returns>
        public static string FromCamelCaseToPascalCase(this string str)
        {
            ThrowIfHasWhiteSpace(str);

            return $"{str.Substring(0, 1).ToUpper()}{str.Substring(1)}";
        }

        /// <summary>
        /// Converts a string in camelCase to a string in kebab-case
        /// </summary>
        /// <param name="str">Camel case string</param>
        /// <returns>Kebab case string</returns>
        public static string FromCamelCaseToKebabCase(this string str)
        {
            ThrowIfHasWhiteSpace(str);

            return str
                .SplitCamelCase()
                .Aggregate((subStrA, subStrB) => $"{subStrA}-{subStrB}")
                .ToLowerInvariant();
        }

        /// <summary>
        /// Converts a string in camelCase to a string in snake_case
        /// </summary>
        /// <param name="str">Camel case string</param>
        /// <returns>Snake case string</returns>
        public static string FromPascalCaseToSnakeCase(this string str)
        {
            ThrowIfHasWhiteSpace(str);

            return str
                .FromPascalCaseToCamelCase()
                .FromCamelCaseToSnakeCase();
        }

        /// <summary>
        /// Converts a string in camelCase to a string in PascalCase
        /// </summary>
        /// <param name="str">Camel case string</param>
        /// <returns>Pascal case string</returns>
        public static string FromPascalCaseToCamelCase(this string str)
        {
            ThrowIfHasWhiteSpace(str);

            return $"{str.Substring(0, 1).ToLower()}{str.Substring(1)}";
        }

        /// <summary>
        /// Converts a string in camelCase to a string in kebab-case
        /// </summary>
        /// <param name="str">Camel case string</param>
        /// <returns>Kebab case string</returns>
        public static string FromPascalCaseToKebabCase(this string str)
        {
            ThrowIfHasWhiteSpace(str);

            return str
                .FromPascalCaseToCamelCase()
                .FromCamelCaseToKebabCase();
        }

        private static void ThrowIfHasWhiteSpace(string str)
        {
            if (str.Contains(' '))
            {
                throw new NotSupportedException("Casing converting does not support strings with whitespaces.");
            }
        }
    }
}
