namespace Strong.Numeric
{
    public static class Validations
    {
        /// <summary>
        /// Validates if a number is even
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true if even or false if odd</returns>
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        /// <summary>
        /// Validates if a number is odd
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true if odd or false if even</returns>
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

        /// <summary>
        /// Validates if a number is divisable by another number. Quocient equals 0
        /// </summary>
        /// <param name="number"></param>
        /// <param name="divider">Divider</param>
        /// <returns>true if quocient is 0 or false if quocient is different of 0</returns>
        public static bool IsDivisableBy(this int number, int divider)
        {
            return number % divider == 0;
        }
    }
}
