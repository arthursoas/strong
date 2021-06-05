using System;
using System.Text.Json;

namespace Strong.Json
{
    public static class Validating
    {
        /// <summary>
        /// Validates if a string is a valid JSON or not
        /// </summary>
        /// <param name="str">Potential JSON</param>
        /// <returns>true if is JSON or false if not</returns>
        public static bool IsJson(this string str)
        {
            if (!(str.StartsWith("{") && str.EndsWith("}")))
            {
                return false;
            }

            try
            {
                JsonDocument.Parse(str);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
