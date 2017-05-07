using System;
using NUnit;
using NUnit.Framework;
using githubTests;

namespace githubTestsTest
{
    [TestFixture]
    public class githubTestsTest
    {
        private CaseInverter ci;
        public githubTestsTest()
        {
            ci = new CaseInverter();
        }
        [Test]
        public void TestOrder()
        {
            Assert.AreEqual("321", ci.orderInverter("123"));
            Assert.AreEqual("nitsûguA",ci.orderInverter("Augûstin"));
            Assert.AreEqual("n#tsûguA",ci.orderInverter("Augûst#n"));
            Assert.AreEqual( "#",ci.orderInverter("#"));
            Assert.AreEqual("", ci.orderInverter(""));
        }
    }
}
