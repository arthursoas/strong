using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace Strong.Tests
{
    [TestClass]
    public class ValidationsTests
    {
        [DataTestMethod]
        [DataRow("", true)]
        [DataRow(" ", true)]
        [DataRow("   ", true)]
        [DataRow(null, true)]
        [DataRow("content", false)]
        public void IsEmpty(string str, bool isEmpty)
        {
            // Act
            var result = str.IsEmpty();

            // Assert
            result.ShouldBe(isEmpty);
        }
    }
}
