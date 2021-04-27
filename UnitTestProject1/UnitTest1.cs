using AddTwoNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Program program;
        public UnitTest1()
        {
             program = new Program();
        }
        [TestMethod]
        public void TestMethod1()
        {
            var result = program.Add(5,5);
            Assert.AreEqual(10,result);
        }
    }
}
