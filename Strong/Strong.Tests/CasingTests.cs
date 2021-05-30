using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace Strong.Tests
{
    [TestClass]
    public class CasingTests
    {
        [DataTestMethod]
        [DataRow("some_string", "someString")]
        [DataRow("Some_String", "someString")]
        [DataRow("SOME_STRING", "someString")]
        [DataRow("_some_string", "someString")]
        [DataRow("some_string_", "someString")]
        [DataRow("_some_string_", "someString")]
        [DataRow("__some____string", "someString")]
        [DataRow("s_o_m_e_string", "sOMEString")]
        public void FromSnakeCaseToCamelCase(string snakeCase, string camelCase)
        {
            // Act
            var result = snakeCase.FromSnakeCaseToCamelCase();

            // Assert
            result.ShouldBe(camelCase);
        }

        [DataTestMethod]
        [DataRow("some_string", "SomeString")]
        [DataRow("Some_String", "SomeString")]
        [DataRow("SOME_STRING", "SomeString")]
        [DataRow("_some_string", "SomeString")]
        [DataRow("some_string_", "SomeString")]
        [DataRow("_some_string_", "SomeString")]
        [DataRow("__some____string", "SomeString")]
        [DataRow("s_o_m_e_string", "SOMEString")]
        public void FromSnakeCaseToPascalCase(string snakeCase, string pascalCase)
        {
            // Act
            var result = snakeCase.FromSnakeCaseToPascalCase();

            // Assert
            result.ShouldBe(pascalCase);
        }
    }
}
