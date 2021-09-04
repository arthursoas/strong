using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Strong.Numeric.Text;

namespace Strong.Numeric.Tests.Text
{
    [TestClass]
    public class ConversionsTests
    {
        [DataTestMethod]
        [DataRow(0, "zero")]
        [DataRow(20, "twenty")]
        [DataRow(31, "thirty-one")]
        [DataRow(203, "two hundred three")]
        [DataRow(1_001, "one thousand one")]
        [DataRow(55_230, "fifty-five thousand two hundred thirty")]
        [DataRow(104_000, "one hundred four thousand")]
        [DataRow(72_300_005, "seventy-two million three hundred thousand five")]
        [DataRow(2_020_090_005, "two billion twenty million ninety thousand five")]
        public void ToWrittenNumber(int number, string writtenNumber)
        {
            // Act
            var result = number.ToWrittenNumber();

            // Asser
            result.ShouldBe(writtenNumber);
        }
    }
}
