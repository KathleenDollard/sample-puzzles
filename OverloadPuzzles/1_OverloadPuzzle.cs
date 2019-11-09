using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace methods_and_overloads
{
    [TestClass]
    public class OverloadsPuzzle
    {
        [TestMethod]
        [TestCategory("Overloads")]
        public void OverloadsTest()
        {
            Int16 itemInt16 = 42;
            Int32 itemInt32 = 42;
            Int64 itemInt64 = 42;
            DateTime itemDate = new DateTime(2006, 03, 25);

            Assert.IsTrue(Test(itemInt32).StartsWith("abc"));
            Assert.IsTrue(Test(itemInt64).StartsWith("abc"));
            Assert.IsTrue(Test(itemDate).StartsWith("abc"));

            Assert.IsTrue(Test(itemInt16).StartsWith("abc"));
        }

        private string Test(Int32 item)
        { return "Int32 version"; }

        private string Test(Int16 item)
        { return "Int164 version"; }

        private string Test(object item)
        { return "Object version"; }
    }
}
