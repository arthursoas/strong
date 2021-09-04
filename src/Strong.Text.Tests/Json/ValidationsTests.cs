using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Strong.Text.Json;

namespace Strong.Text.Tests.Json
{
    [TestClass]
    public class ValidationsTests
    {
        [DataTestMethod]
        [DataRow("{}", true)]
        [DataRow("{\"key\": \"value\"}", true)]
        [DataRow("{\"key\": true}", true)]
        [DataRow("{\"key\": []}", true)]
        [DataRow("{\"key\": {}}", true)]
        [DataRow("{\"key\": null}", true)]
        [DataRow("{\"key\": 0}", true)]
        [DataRow("{\"key\": 0.1}", true)]
        [DataRow("{\"key\": value}", false)]
        [DataRow("{key: \"value\"}", false)]
        [DataRow("{key: value}", false)]
        [DataRow("[]", true)]
        [DataRow("[key, value]", false)]
        [DataRow("[\"key\", \"value\"]", true)]
        public void IsJson(string json, bool isJson)
        {
            // Act
            var result = json.IsJson();

            // Assert
            result.ShouldBe(isJson);
        }
    }
}
