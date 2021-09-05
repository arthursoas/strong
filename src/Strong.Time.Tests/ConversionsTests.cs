using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;

namespace Strong.Time.Tests
{
    [TestClass]
    public class ConversionsTests
    {
        [DataTestMethod]
        [DataRow(2000, 10, 10, 15, 00, 00, "2000-10-10T15:00:00.0000000Z")]
        [DataRow(2020, 01, 01, 00, 00, 00, "2020-01-01T00:00:00.0000000Z")]
        public void DateTime_ToIso8601(int year, int month, int day, int hour, int minute, int second, string iso8601)
        {
            // Arrange
            var dateTime = new DateTime(year, month, day, hour, minute, second);

            // Act
            var result = dateTime.ToIso8601();

            // Assert
            result.ShouldBe(iso8601);
        }

        [DataTestMethod]
        [DataRow(2000, 10, 10, 15, 00, 00, -3, "2000-10-10T15:00:00.0000000-03:00")]
        [DataRow(2020, 01, 01, 00, 00, 00, +0, "2020-01-01T00:00:00.0000000+00:00")]
        public void DateTimeOffset_ToIso8601(int year, int month, int day, int hour, int minute, int second, int offset, string iso8601)
        {
            // Arrange
            var dateTimeOffset = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.FromHours(offset));

            // Act
            var result = dateTimeOffset.ToIso8601();

            // Assert
            result.ShouldBe(iso8601);
        }
    }
}
