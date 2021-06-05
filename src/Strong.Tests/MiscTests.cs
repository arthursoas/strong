using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strong.Tests
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
    }
}
