using System;
using System.Linq;

namespace Strong.Text.Numeric
{
    public static class Conversions
    {
        private const string NEGATIVE_KEYWORD = "negative";
        private const string HUNDRED_KEYWORD = "hundred";

        /// <summary>
        /// Convert a number in written form to numeric form
        /// </summary>
        /// <param name="str">Number in written form</param>
        /// <returns>Number in numeric form</returns>
        public static int FromWrittenNumberToInt(this string str)
        {
            str = NormalizeWrittenNumber(str);
            var isNegative = str.StartsWith(NEGATIVE_KEYWORD);
            str = str.RemoveFirstOcurrence(NEGATIVE_KEYWORD);

            var accumulator = 0;

            foreach (var multiplier in Numbers.WrittenNumberMultipliers)
            {
                if (str.Contains(multiplier.Key))
                {
                    var tokens = str.Split(multiplier.Key, 2, StringSplitOptions.RemoveEmptyEntries);
                    accumulator += ConvertSlice(tokens.First()) * multiplier.Value;
                    str = tokens.Length > 1 ? tokens.Last() : "";
                }
            }

            accumulator += ConvertSlice(str);

            return isNegative ? -accumulator : accumulator;
        }

        private static int ConvertSlice(string slice)
        {
            if (slice.IsEmpty())
            {
                return 0;
            }

            var tokens = slice
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim());

            return tokens
                .Select(t => Numbers.WrittenNumbers[t])
                .Aggregate(0, (acc, token) =>
                {
                    if (token == Numbers.WrittenNumbers[HUNDRED_KEYWORD])
                    {
                        return acc * token;
                    }
                    return acc + token;
                });
        }

        private static string NormalizeWrittenNumber(string writtenNumber)
        {
            writtenNumber = writtenNumber
                .Replace(" and", "")
                .Replace(",", "")
                .Replace("-", " ")
                .Replace("thousands", "thousand")
                .Replace("hundreds", "hundred")
                .Replace("millions", "million")
                .Replace("billions", "billion")
                .ToLowerInvariant()
                .SuperTrim();

            return writtenNumber;
        }
    }
}