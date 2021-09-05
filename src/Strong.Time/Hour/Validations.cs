using System;

namespace Strong.Time.Hour
{
    public static class Validations
    {
        /// <summary>
        /// Validates if a dte time is a 9 to 5 business hour.
        /// </summary>
        /// <param name="dateTime">Date time</param>
        /// <returns>True if business hour or false if not business hour</returns>
        public static bool IsBusinessHour9To5(this DateTime dateTime)
        {
            return dateTime.Hour >= 9 && dateTime.Hour <= 17;
        }

        /// <summary>
        /// Validates if a dte time is a 9 to 5 business hour.
        /// </summary>
        /// <param name="dateTimeOffset">Date time offset</param>
        /// <returns>True if business hour or false if not business hour</returns>
        public static bool IsBusinessHour9To5(this DateTimeOffset dateTimeOffset)
        {
            return IsBusinessHour9To5(dateTimeOffset.DateTime);
        }
    }
}
