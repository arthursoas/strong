namespace Strong
{
    public static class Validations
    {
        /// <summary>
        /// Validate if a string is null, empty or whitespace
        /// </summary>
        /// <param name="str"></param>
        /// <returns>true if is empty or false if not</returns>
        public static bool IsEmpty(this string str)
        {
            return str == null || str.SuperTrim() == "";
        }
    }
}
