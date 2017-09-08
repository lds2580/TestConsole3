using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        TestConsole.Class1 cls = new TestConsole.Class1();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, cls.TestCheck());
        }
    }
}
