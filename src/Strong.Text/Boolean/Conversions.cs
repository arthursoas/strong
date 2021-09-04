using System;

namespace Strong.Text.Boolean
{
    public static class Conversions
    {
        /// <summary>
        /// Converts a string to bool
        /// </summary>
        /// <param name="str">Potential bool</param>
        /// <returns>bool</returns>
        public static bool ToBool(this string str)
        {
            str = str.ToLower();

            if (str.Equals("true") || str.Equals("t") ||
                str.Equals("yes") || str.Equals("y") ||
                str.Equals("1"))
            {
                return true;
            }

            if (str.Equals("false") || str.Equals("f") ||
                str.Equals("no") || str.Equals("n") ||
                str.Equals("0"))
            {
                return false;
            }

            throw new NotSupportedException("The value cannot be converted to bool.");
        }
    }
}
