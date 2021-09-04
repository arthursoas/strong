using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Strong.Text.Numeric;

namespace Strong.Text.Tests.Numeric
{
    [TestClass]
    public class ConversionsTests
    {
        [DataTestMethod]
        [DataRow("zero", 0)]
        [DataRow("Negative one", -1)]
        [DataRow("One", 1)]
        [DataRow("Ten", 10)]
        [DataRow("Two hundred", 200)]
        [DataRow("Eleven hundred", 1100)]
        [DataRow("Three thousand", 3000)]
        [DataRow("Four million", 4000000)]
        [DataRow("Two billion", 2000000000)]
        [DataRow("Forty-five", 45)]
        [DataRow("One hundred and one", 101)]
        [DataRow("One hundred ten", 110)]
        [DataRow("One hundred ninety", 190)]
        [DataRow("One billion and two millions", 1002000000)]
        [DataRow("One billion, two millions and three thousand", 1002003000)]
        [DataRow("One billion, two millions, three thousand and four hundred", 1002003400)]
        [DataRow("One billion, two millions, three thousand, four hundred and five", 1002003405)]
        [DataRow("Fifty-four million, four hundred and thirty-two thousand, seven hundred and eighty-two", 54432782)]
        [DataRow("Ninety million, eight hundred and seven thousand and sixty", 90807060)]
        public void FromWrittenNumberToInt(string written, int integer)
        {
            // Act
            var result = written.FromWrittenNumberToInt();

            // Assert
            result.ShouldBe(integer);
        }
    }
}
