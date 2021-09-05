using System;

namespace Strong.Time.Week
{
    public static class Misc
    {
        /// <summary>
        /// Get the next buisness day considering a date time.
        /// If the informed date time is already a business day, it will be returned.
        /// </summary>
        /// <param name="dateTime">Date time</param>
        /// <returns>Date time with the next business day</returns>
        public static DateTime NextBusinessDay(this DateTime dateTime)
        {
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    return dateTime.AddDays(2);
                case DayOfWeek.Sunday:
                    return dateTime.AddDays(1);
                default:
                    return dateTime;
            }
        }

        /// <summary>
        /// Get the next buisness day considering a date time offset.
        /// If the informed date time offset is already a business day, it will be returned.
        /// </summary>
        /// <param name="dateTimeOffset">Date time offset</param>
        /// <returns>Date time offset with the next business day</returns>
        public static DateTimeOffset NextBusinessDay(this DateTimeOffset dateTimeOffset)
        {
            switch (dateTimeOffset.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    return dateTimeOffset.AddDays(2);
                case DayOfWeek.Sunday:
                    return dateTimeOffset.AddDays(1);
                default:
                    return dateTimeOffset;
            }
        }
    }
}
