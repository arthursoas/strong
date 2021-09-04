using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Strong.Text.Casing;
using System.Linq;

namespace Strong.Text.Tests.Casing
{
    [TestClass]
    public class SplitionsTests
    {
        [DataTestMethod]
        [DataRow(new string[] { "some", "string" }, "someString")]
        [DataRow(new string[] { "s", "o", "m", "e", "s", "t", "r", "i", "n", "g" }, "sOMESTRING")]
        [DataRow(new string[] { "somestring" }, "somestring")]
        [DataRow(new string[] { "some", "string" }, "some    string")]
        public void SplitCamelCase(string[] words, string camelCase)
        {
            // Act
            var result = camelCase.SplitCamelCase().ToArray();

            // Assert
            result.Length.ShouldBe(words.Length);
            for (var index = 0; index < words.Length; index ++)
            {
                result[index].ShouldBe(words[index]);
            }
        }
    }
}
