using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace Strong.Text.Tests
{
    [TestClass]
    public class MiscTests
    {
        [DataTestMethod]
        [DataRow("some string", "some string")]
        [DataRow("some        string", "some string")]
        [DataRow("  some string", "some string")]
        [DataRow("some string    ", "some string")]
        [DataRow("    some string    ", "some string")]
        [DataRow("    some     string    ", "some string")]
        public void SuperTrim(string str, string trimmedStr)
        {
            // Act
            var result = str.SuperTrim();

            // Assert
            result.ShouldBe(trimmedStr);
        }

        [DataTestMethod]
        [DataRow("repeated value repeat", "repeat", "ed value repeat")]
        [DataRow("repeated value", "repeat", "ed value")]
        [DataRow("repeated value repeat", null, "repeated value repeat")]
        [DataRow("repeated value repeat", "not present value", "repeated value repeat")]
        public void RemoveFirstStringOcurrence(string str, string toRemove, string removedStr)
        {
            // Act
            var result = str.RemoveFirstOcurrence(toRemove);

            // Assert
            result.ShouldBe(removedStr);
        }

        [DataTestMethod]
        [DataRow("repeated value repeat", 'r', "epeated value repeat")]
        [DataRow("repeated value", 'r', "epeated value")]
        [DataRow("repeated value repeat", null, "repeated value repeat")]
        [DataRow("repeated value repeat", 'x', "repeated value repeat")]
        public void RemoveFirstCharOcurrence(string str, char toRemove, string removedStr)
        {
            // Act
            var result = str.RemoveFirstOcurrence(toRemove);

            // Assert
            result.ShouldBe(removedStr);
        }
    }
}
