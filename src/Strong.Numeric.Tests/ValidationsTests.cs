using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace Strong.Numeric.Tests
{
    [TestClass]
    public class ValidationsTests
    {
        [DataTestMethod]
        [DataRow(0, true)]
        [DataRow(2, true)]
        [DataRow(3, false)]
        [DataRow(-2, true)]
        [DataRow(-3, false)]
        public void IsEven(int number, bool isEven)
        {
            // Act
            var result = number.IsEven();

            // Asser
            result.ShouldBe(isEven);
        }

        [DataTestMethod]
        [DataRow(0, false)]
        [DataRow(2, false)]
        [DataRow(3, true)]
        [DataRow(-2, false)]
        [DataRow(-3, true)]
        public void IsOdd(int number, bool isOdd)
        {
            // Act
            var result = number.IsOdd();

            // Asser
            result.ShouldBe(isOdd);
        }

        [DataTestMethod]
        [DataRow(0, 10, true)]
        [DataRow(2, 1, true)]
        [DataRow(10, 5, true)]
        [DataRow(-10, 5, true)]
        [DataRow(10, -5, true)]
        [DataRow(10, 3, false)]
        [DataRow(10, -3, false)]
        [DataRow(-10, -3, false)]
        public void IsDivisableBy(int number, int diviser, bool isDivisable)
        {
            // Act
            var result = number.IsDivisableBy(diviser);

            // Asser
            result.ShouldBe(isDivisable);
        }
    }
}
