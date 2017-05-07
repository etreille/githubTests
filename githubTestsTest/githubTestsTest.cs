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
            Assert.AreEqual("nits�guA",ci.orderInverter("Aug�stin"));
            Assert.AreEqual("n#ts�guA",ci.orderInverter("Aug�st#n"));
            Assert.AreEqual( "#",ci.orderInverter("#"));
            Assert.AreEqual("", ci.orderInverter(""));
        }
    }
}
