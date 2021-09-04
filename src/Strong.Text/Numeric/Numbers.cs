using System.Collections.Generic;

namespace Strong.Text.Numeric
{
    public static class Numbers
    {
        public static IDictionary<string, int> WrittenNumbers { get; } = new Dictionary<string, int>
        {
            { "zero", 0 },
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 },
            { "ten", 10 },
            { "eleven", 11 },
            { "twelve", 12 },
            { "thirteen", 13 },
            { "fourteen", 14 },
            { "fifteen", 15 },
            { "sixteen", 16 },
            { "seventeen", 17 },
            { "eightteen", 18 },
            { "nineteen", 19 },
            { "twenty", 20 },
            { "thirty", 30 },
            { "forty", 40 },
            { "fifty", 50 },
            { "sixty", 60 },
            { "seventy", 70 },
            { "eighty", 80 },
            { "ninety", 90 },
            { "hundred", 100 },
        };

        public static IDictionary<string, int> WrittenNumberMultipliers { get; } = new Dictionary<string, int>
        {
            { "billion", 1_000_000_000 },
            { "million", 1_000_000 },
            { "thousand", 1_000 },
        };
    }
}