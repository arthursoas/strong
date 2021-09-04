using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Strong.Text.Numeric;

namespace Strong.Text.Tests.Numeric
{
    [TestClass]
    public class ValidationsTests
    {
        [DataTestMethod]
        [DataRow("0", true)]
        [DataRow("1", true)]
        [DataRow("-1", true)]
        [DataRow("0.1", false)]
        [DataRow("string", false)]
        public void IsInteger(string integer, bool isInteger)
        {
            // Arrange
            var result = integer.IsInteger();

            // act
            result.ShouldBe(isInteger);
        }

        [DataTestMethod]
        [DataRow("0", true)]
        [DataRow("1", true)]
        [DataRow("-1", true)]
        [DataRow("0.1", true)]
        [DataRow("-0.1", true)]
        [DataRow("string", false)]
        public void IsFloat(string @float, bool isFloat)
        {
            // Arrange
            var result = @float.IsFloat();

            // act
            result.ShouldBe(isFloat);
        }
    }
}
