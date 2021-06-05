using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Strong.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strong.Tests.Json
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
        [DataRow("[]", false)]
        [DataRow("[key, value]", false)]
        [DataRow("[\"key\", \"value\"]", false)]
        public void IsJson(string json, bool isJson)
        {
            // Act
            var result = json.IsJson();

            // Assert
            result.ShouldBe(isJson);
        }
    }
}
