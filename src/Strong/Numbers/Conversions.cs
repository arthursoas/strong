using System;
using System.Linq;
using System.Text;

namespace Strong.Numbers
{
    public static class Conversions
    {
        public static int FromWrittenNumberToInt(this string str)
        {
            str = NormalizeWrittenNumber(str);

            var numberBuilder = new StringBuilder();

            numberBuilder.Append(CreateSlice("trillion", ref str));
            numberBuilder.Append(CreateSlice("billion", ref str));
            numberBuilder.Append(CreateSlice("million", ref str));
            numberBuilder.Append(CreateSlice("thousand", ref str));
            numberBuilder.Append(CreateSlice(null, ref str));

            return int.Parse(numberBuilder.ToString());
        }

        private static string CreateSlice(string separator, ref string str)
        {
            if (str.IsEmpty()) return "000";
            
            var slices = str.Split(
                    separator,
                    2,
                    StringSplitOptions.RemoveEmptyEntries);

            if (separator == null || str.EndsWith(separator))
            {
                str = "";
                return CreateHundredSlice(slices.First());
            }

            if (slices.Count() > 1)
            {
                str = slices.Last();
                return CreateHundredSlice(slices.First());
            }
               
            return "000";
        }

        private static string CreateHundredSlice(string slice)
        {
            if (slice.IsEmpty()) return "000";

            var numberBuilder = new StringBuilder();

            var hundreds = slice
                .Split("hundred", StringSplitOptions.RemoveEmptyEntries)
                .Select(sl => sl.Trim());
            
            if (slice.EndsWith("hundred"))
            {
                var number = Numbers.WrittenNumbers[hundreds.First()];
                numberBuilder.Append(number).Append("00");

                return numberBuilder.ToString();
            }

            if (hundreds.Count() > 1)
            {
                var number = Numbers.WrittenNumbers[hundreds.First()];
                numberBuilder.Append(number);
                slice = hundreds.Last();
            }
            else
            {
                numberBuilder.Append("0");
            }

            var decimals = slice
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(dc => dc.Trim());
            if (slice.IsEmpty())
            {
                numberBuilder.Append("00");

                return numberBuilder.ToString();
            }

            if (decimals.Count() > 1)
            {
                var @decimal = Numbers.WrittenNumbers[decimals.First()];
                var decimalUnit = Numbers.WrittenNumbers[decimals.Last()];
                numberBuilder.Append(@decimal.Replace("0", decimalUnit));

                return numberBuilder.ToString();
            }

            var unit = Numbers.WrittenNumbers[decimals.First()];
            if (unit.Length == 1) numberBuilder.Append("0");
            numberBuilder.Append(unit);

            return numberBuilder.ToString();
        }

        private static string NormalizeWrittenNumber(string writtenNumber)
        {
            writtenNumber = writtenNumber.Replace(" and", "");
            writtenNumber = writtenNumber.Replace(",", "");
            writtenNumber = writtenNumber.Replace("-", " ");
            writtenNumber = writtenNumber.Replace("thousands", "thousand");
            writtenNumber = writtenNumber.Replace("hundreds", "hundred");
            writtenNumber = writtenNumber.Replace("millions", "million");
            writtenNumber = writtenNumber.Replace("billions", "billion");
            writtenNumber = writtenNumber.ToLowerInvariant();
            writtenNumber = writtenNumber.SuperTrim();

            return writtenNumber;
        }
    }
}
