using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 42;
            int b = 24;
            int x = TestMethod0(a);
            Assert.AreEqual(b, x);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int a = 0;
            int b = 0;
            int x = TestMethod0(a);
            Assert.AreEqual(b, x);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int a = 5;
            int b = 5;
            int x = TestMethod0(a);
            Assert.AreEqual(b, x);
        }
        private int TestMethod0(int x)
        {
            if (x < 10 || x > 99)
            {
                return x;
            }
            int a = x / 10;
            int b = x % 10;
            return b * 10 + a;
        }
    }
}
