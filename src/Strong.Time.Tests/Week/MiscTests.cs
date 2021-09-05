using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Strong.Time.Week;
using System;

namespace Strong.Time.Tests.Week
{
    [TestClass]
    public class MiscTests
    {
        [DataTestMethod]
        [DataRow(2021, 09, 06, 06)]
        [DataRow(2021, 09, 05, 06)]
        [DataRow(2021, 09, 04, 06)]
        public void DateTime_NextBusinessDay(int year, int month, int day, int nextBusinessDay)
        {
            // Arrange
            var dateTime = new DateTime(year, month, day);

            // Act
            var result = dateTime.NextBusinessDay();

            // Assert
            result.Day.ShouldBe(nextBusinessDay);
        }

        [DataTestMethod]
        [DataRow(2021, 09, 06, 06)]
        [DataRow(2021, 09, 05, 06)]
        [DataRow(2021, 09, 04, 06)]
        public void DateTimeOffset_NextBusinessDay(int year, int month, int day, int nextBusinessDay)
        {
            // Arrange
            var dateTimeOffset = new DateTimeOffset(new DateTime(year, month, day));

            // Act
            var result = dateTimeOffset.NextBusinessDay();

            // Assert
            result.Day.ShouldBe(nextBusinessDay);
        }
    }
}
