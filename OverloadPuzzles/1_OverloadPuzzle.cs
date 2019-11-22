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

            Assert.IsTrue(Test(itemInt32).StartsWith("Int32"));
            Assert.IsTrue(Test(itemInt64).StartsWith("Int64"));
            Assert.IsTrue(Test(itemDate).StartsWith("Object"));

            Assert.IsTrue(Test(itemInt16).StartsWith("Int32"));
        }

        private string Test(Int32 item) => "Int32 version";
        private string Test(Int64 item) => "Int64 version";
        private string Test(object item) => "Object version";
    }
}
