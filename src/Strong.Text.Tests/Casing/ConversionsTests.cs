using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Strong.Text.Casing;

namespace Strong.Text.Tests.Casing
{
    [TestClass]
    public class ConversionsTests
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
        [DataRow("somestring", "somestring")]
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
        [DataRow("somestring", "Somestring")]
        public void FromSnakeCaseToPascalCase(string snakeCase, string pascalCase)
        {
            // Act
            var result = snakeCase.FromSnakeCaseToPascalCase();

            // Assert
            result.ShouldBe(pascalCase);
        }

        [DataTestMethod]
        [DataRow("some_string", "some-string")]
        [DataRow("Some_String", "some-string")]
        [DataRow("SOME_STRING", "some-string")]
        [DataRow("_some_string", "some-string")]
        [DataRow("some_string_", "some-string")]
        [DataRow("_some_string_", "some-string")]
        [DataRow("__some____string", "some-string")]
        [DataRow("s_o_m_e_string", "s-o-m-e-string")]
        [DataRow("somestring", "somestring")]
        public void FromSnakeCaseToKebabCase(string snakeCase, string kebabCase)
        {
            // Act
            var result = snakeCase.FromSnakeCaseToKebabCase();

            // Assert
            result.ShouldBe(kebabCase);
        }

        [DataTestMethod]
        [DataRow("someString", "some_string")]
        [DataRow("sOMESTRING", "s_o_m_e_s_t_r_i_n_g")]
        [DataRow("somestring", "somestring")]
        public void FromCamelCaseToSnakeCase(string camelCase, string snakeCase)
        {
            // Act
            var result = camelCase.FromCamelCaseToSnakeCase();

            // Assert
            result.ShouldBe(snakeCase);
        }

        [DataTestMethod]
        [DataRow("someString", "SomeString")]
        [DataRow("sOMESTRING", "SOMESTRING")]
        [DataRow("somestring", "Somestring")]
        public void FromCamelCaseToPascalCase(string camelCase, string pascalCase)
        {
            // Act
            var result = camelCase.FromCamelCaseToPascalCase();

            // Assert
            result.ShouldBe(pascalCase);
        }

        [DataTestMethod]
        [DataRow("someString", "some-string")]
        [DataRow("sOMESTRING", "s-o-m-e-s-t-r-i-n-g")]
        [DataRow("somestring", "somestring")]
        public void FromCamelCaseToKebabCase(string camelCase, string kebabCase)
        {
            // Act
            var result = camelCase.FromCamelCaseToKebabCase();

            // Assert
            result.ShouldBe(kebabCase);
        }

        [DataTestMethod]
        [DataRow("SomeString", "some_string")]
        [DataRow("SOMESTRING", "s_o_m_e_s_t_r_i_n_g")]
        [DataRow("Somestring", "somestring")]
        public void FromPascalCaseToSnakeCase(string pascal, string snakeCase)
        {
            // Act
            var result = pascal.FromPascalCaseToSnakeCase();

            // Assert
            result.ShouldBe(snakeCase);
        }

        [DataTestMethod]
        [DataRow("SomeString", "someString")]
        [DataRow("SOMESTRING", "sOMESTRING")]
        [DataRow("Somestring", "somestring")]
        public void FromPascalCaseToCamelCase(string pascalCase, string camelCase)
        {
            // Act
            var result = pascalCase.FromPascalCaseToCamelCase();

            // Assert
            result.ShouldBe(camelCase);
        }

        [DataTestMethod]
        [DataRow("SomeString", "some-string")]
        [DataRow("SOMESTRING", "s-o-m-e-s-t-r-i-n-g")]
        [DataRow("Somestring", "somestring")]
        public void FromPascalCaseToKebabCase(string pascalCase, string kebabCase)
        {
            // Act
            var result = pascalCase.FromPascalCaseToKebabCase();

            // Assert
            result.ShouldBe(kebabCase);
        }
    }
}
