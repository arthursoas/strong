using System;

namespace Strong.Numeric
{
    public static class Validations
    {
        /// <summary>
        /// Validates if a string is a integer
        /// </summary>
        /// <param name="str">Potential integer</param>
        /// <returns>True if is integer or false if not</returns>
        public static bool IsInteger(this string str)
        {
            try
            {
                int.Parse(str);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Validates if a string is a float
        /// </summary>
        /// <param name="str">Potential float</param>
        /// <returns>True if is float or false if not</returns>
        public static bool IsFloat(this string str)
        {
            try
            {
                float.Parse(str);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
