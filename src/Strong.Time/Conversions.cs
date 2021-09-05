using System;
using System.Globalization;

namespace Strong.Time
{
    public static class Conversions
    {
        /// <summary>
        /// Converts a date time to ISO-8601 format.
        /// </summary>
        /// <param name="dateTime">Date time</param>
        /// <returns>ISO-8601 date (2000-01-01T00:00:00.0000000Z)</returns>
        public static string ToIso8601(this DateTime dateTime)
        {
            return dateTime.ToString("O", CultureInfo.InvariantCulture) + "Z";
        }

        /// <summary>
        /// Converts a date time offset to ISO-8601 format.
        /// </summary>
        /// <param name="dateTimeOffset">Date time offset</param>
        /// <returns>ISO-8601 date (2000-01-01T00:00:00.0000000Z)</returns>
        public static string ToIso8601(this DateTimeOffset dateTimeOffset)
        {
            return dateTimeOffset.ToString("O", CultureInfo.InvariantCulture);
        }
    }
}
