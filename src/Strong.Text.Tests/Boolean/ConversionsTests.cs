using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Strong.Text.Boolean;

namespace Strong.Text.Tests.Boolean
{
    [TestClass]
    public class ConversionsTests
    {
        [DataTestMethod]
        [DataRow("True", true)]
        [DataRow("true", true)]
        [DataRow("T", true)]
        [DataRow("t", true)]
        [DataRow("yes", true)]
        [DataRow("y", true)]
        [DataRow("1", true)]
        [DataRow("False", false)]
        [DataRow("false", false)]
        [DataRow("F", false)]
        [DataRow("f", false)]
        [DataRow("no", false)]
        [DataRow("0", false)]
        public void ToBool(string potentialBool, bool @bool)
        {
            // Act
            var result = potentialBool.ToBool();

            // Assert
            result.ShouldBe(@bool);
        }
    }
}
