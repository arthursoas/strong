using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Strong.Time.Week;
using System;

namespace Strong.Time.Tests.Week
{
    [TestClass]
    public class ValidationsTests
    {
        [DataTestMethod]
        [DataRow(2021, 09, 06, true)]
        [DataRow(2021, 09, 05, false)]
        [DataRow(2021, 09, 04, false)]
        public void DateTime_IsBusinessDay(int year, int month, int day, bool businessDay)
        {
            // Arrange
            var dateTime = new DateTime(year, month, day);

            // Act
            var result = dateTime.IsBusinessDay();

            // Assert
            result.ShouldBe(businessDay);
        }

        [DataTestMethod]
        [DataRow(2021, 09, 06, true)]
        [DataRow(2021, 09, 05, false)]
        [DataRow(2021, 09, 04, false)]
        public void DateTimeOffset_IsBusinessDay(int year, int month, int day, bool businessDay)
        {
            // Arrange
            var dateTimeOffset = new DateTimeOffset(new DateTime(year, month, day));

            // Act
            var result = dateTimeOffset.IsBusinessDay();

            // Assert
            result.ShouldBe(businessDay);
        }
    }
}
