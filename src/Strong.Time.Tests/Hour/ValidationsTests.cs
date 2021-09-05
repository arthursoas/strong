using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Strong.Time.Hour;
using System;

namespace Strong.Time.Tests.Hour
{
    [TestClass]
    public class ValidationsTests
    {
        [DataTestMethod]
        [DataRow(2000, 10, 10, 15, 00, 00, true)]
        [DataRow(2000, 10, 10, 09, 00, 00, true)]
        [DataRow(2000, 10, 10, 17, 00, 00, true)]
        [DataRow(2020, 01, 01, 00, 00, 00, false)]
        [DataRow(2020, 01, 01, 18, 00, 00, false)]
        public void DateTime_IsBusinessHour9To5(int year, int month, int day, int hour, int minute, int second, bool businessHour)
        {
            // Arrange
            var dateTime = new DateTime(year, month, day, hour, minute, second);

            // Act
            var result = dateTime.IsBusinessHour9To5();

            // Assert
            result.ShouldBe(businessHour);
        }

        [DataTestMethod]
        [DataRow(2000, 10, 10, 15, 00, 00, -3, true)]
        [DataRow(2000, 10, 10, 09, 00, 00, -3, true)]
        [DataRow(2000, 10, 10, 17, 00, 00, -3, true)]
        [DataRow(2020, 01, 01, 00, 00, 00, -3, false)]
        [DataRow(2020, 01, 01, 18, 00, 00, -3, false)]
        public void DateTimeOffset_IsBusinessHour9To5(int year, int month, int day, int hour, int minute, int second, int offset, bool businessHour)
        {
            // Arrange
            var dateTimeOffset = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.FromHours(offset));

            // Act
            var result = dateTimeOffset.IsBusinessHour9To5();

            // Assert
            result.ShouldBe(businessHour);
        }
    }
}
