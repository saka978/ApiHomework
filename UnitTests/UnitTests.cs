using NUnit.Framework;
using ApiHomeWork.Utils;
using System;

namespace UnitTests
{
    public class Tests
    {
        JsonParser jsonParser = new JsonParser();
        private string validJson = "{\"anime\":\"One Punch Man\",\"character\":\"Saitama\",\"quote\":\"If you really want to be strong...Stop caring about what your surrounding thinks of you!\"}";

        [Test]
        public void CheckIfValidJsonIsSuccesfullyParsed()
        {
            string data = jsonParser.getValueByKey(validJson, "anime");
            Assert.AreEqual(data, "One Punch Man");
        }

        [Test]
        public void CheckIfEmptyJsonIsHandledCorrectly()
        {
            string data = jsonParser.getValueByKey("", "anime");
            Assert.AreEqual(data, "");
        }

        [Test]
        public void CheckIfNonExistingKeyIsHandledCorrectly()
        {
            string data = jsonParser.getValueByKey(validJson, "r4andom");
            Assert.AreEqual(data, null);
        }
    }
}