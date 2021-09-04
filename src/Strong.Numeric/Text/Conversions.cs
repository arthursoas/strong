namespace Strong.Numeric.Text
{
    public static class Conversions
    {
        /// <summary>
        /// Converts a integer number to its written form
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The number in written form</returns>
        public static string ToWrittenNumber(this int number)
        {
            if (number == 0)
            {
                return Numbers.WrittenNumbers[0];
            }

            var writtenForm = string.Empty;
            foreach (var multiplier in Numbers.WrittenNumberMultipliers)
            {
                if (number >= multiplier.Key)
                {
                    var slice = number / multiplier.Key;
                    writtenForm += $"{ConvertSlice(slice)} {multiplier.Value} ";
                    number -= slice * multiplier.Key;
                }
            }

            return writtenForm.Trim();
        }

        private static string ConvertSlice(int number)
        {
            var writtenForm = string.Empty;

            var hundred = 100;
            if (number >= hundred)
            {
                var hundreds = number / hundred;
                writtenForm += $"{Numbers.WrittenNumbers[hundreds]} {Numbers.WrittenNumberMultipliers[hundred]} ";
                number -= hundreds * hundred;
            }

            var ten = 10;
            if (number >= ten * 2)
            {
                var tens = number / ten;
                writtenForm += $"{Numbers.WrittenNumbers[tens * ten]}-";
                number -= tens * ten;
            }

            if (number > 0)
            {
                writtenForm += $"{Numbers.WrittenNumbers[number]} ";
            }

            return writtenForm.Remove(writtenForm.Length - 1);
        }
    }
}
