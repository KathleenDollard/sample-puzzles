using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IntrinsicTypeTests
{
    [TestClass]
    public class BasicTypesA
    {
        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void PassAVariable()
        {
            int value = 3;
            string greeting= "Hello";
            Assert.IsTrue((value,greeting),(3,"Hello"));
        }

        public void F(int value, string greeting) 
        {
            value += 1;
            greeting = "Goodbye";
        }



        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void DivideByZeroDecimal()
        {
            //decimal three = 3;
            //decimal zero = 0;
            //decimal result = three / zero;
            //Assert.IsTrue(true);
        }


        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void DivideByZeroDouble()
        {
            //double three = 3;
            //double zero = 0;
            //double result = three / zero;
            //Assert.IsTrue(true);
        }
    }
}
