using System;

namespace Strong.Time.Week
{
    public static class Validations
    {
        /// <summary>
        /// Validates if a date time is a business day (not weekend).
        /// </summary>
        /// <param name="dateTime">Date time</param>
        /// <returns>True if business day or false if weekend</returns>
        public static bool IsBusinessDay(this DateTime dateTime)
        {
            return
                dateTime.DayOfWeek != DayOfWeek.Saturday &&
                dateTime.DayOfWeek != DayOfWeek.Sunday;
        }

        /// <summary>
        /// Validates if a date time offset is a business day (not weekend).
        /// </summary>
        /// <param name="dateTimeOffset">Date time offset</param>
        /// <returns>True if business day or false if weekend</returns>
        public static bool IsBusinessDay(this DateTimeOffset dateTimeOffset)
        {
            return IsBusinessDay(dateTimeOffset.DateTime);
        }
    }
}
