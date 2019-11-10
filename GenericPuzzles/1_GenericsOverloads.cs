using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generics
{
    [TestClass]
    public class GenericOverloads
    {
        public void InferringTypeArguments()
        {
            // These are equivalent
            F<Int32>(42);
            F<int>(42);
            F(42);
        }

        public static void F<T>(T param)
        { }

        [TestMethod]
        [TestCategory("Generics")]
        [TestCategory("Overloads")]
        public void GenericOverloadsTest()
        {
            Int16 itemInt16 = 42;
            Int32 itemInt32 = 42;
            Int64 itemInt64 = 42;
            DateTime itemDate = new DateTime(2006, 03, 25);

            //Assert.IsTrue(Test(itemInt32).StartsWith("??"));
            //Assert.IsTrue(Test(itemInt64).StartsWith("??"));
            //Assert.IsTrue(Test(itemDate).StartsWith ("??"));                                                    
            //Assert.IsTrue(Test(itemInt16).StartsWith("??"));
        }

        private string Test(Int64 item) => "Int64 version";
        private string Test(Int32 item) => "Int32 version";
        private string Test<T>(T item) => "Generic version";
    }
}
