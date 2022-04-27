using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DelegateDemo;

namespace DemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddNumber()
        {
            DelegateDemo dm = new DelegateDemo();
            int res = dm.AddNumber(10);
            Assert.AreEqual(res, 110);
        }

        [TestMethod]
        public void Test_MultiplyNumber()
        {
            DelegateDemo dm = new DelegateDemo();
            int res = dm.MultiplyNumber(10);
            Assert.AreEqual(res, 20);
        }

        [TestMethod]
        public void Test_PrintHelloWorld()
        {
            DelegateDemo dm = new DelegateDemo();
            string res = dm.PrintHelloWorld();
            Assert.AreEqual(res, "Hello World");
        }

        [TestMethod]
        public void Test_CalculateNumbers()
        {
            DelegateDemo dm = new DelegateDemo();
            int res = dm.CalculateNumbers(10.2, 2.2);
            Assert.AreEqual(res, 22);
        }
    }
}
