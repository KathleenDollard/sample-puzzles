using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IntrinsicTypeTests
{
    [TestClass]
    public class TopOfTheType
    {
        [TestMethod]
        //[ExpectedException(typeof(Exception), AllowDerivedTypes=true)]
        public void TopOfInteger()
        {
            int top = int.MaxValue;
            int next = top + 1;
            //Assert.IsTrue(true);
            //Assert.AreEqual(next, ?));
        }



        [TestMethod]
        //[ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void TopOfDouble()
        {
            //double top = double.MaxValue;
            //double next = top + 1;
            //Assert.IsTrue(true);
            //Assert.IsTrue( double.IsInfinity(next));
        }




        [TestMethod]
        //[ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void TopOfSingle()
        {
            //Single top = Single.MaxValue;
            //Single next = top + 1E32F;
            //Assert.IsTrue(true);
            //Assert.IsTrue(Single.IsInfinity(next));
        }

        [TestMethod]
        //[ExpectedException(typeof(OverflowException), AllowDerivedTypes = true)]
        public void TopOfDecimal()
        {
            //decimal top = decimal.MaxValue;
            //decimal next = top + 1;
            //Assert.IsTrue(true);
            //Assert.AreEqual(next, ?));
        }


        [TestMethod]
        //[ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void TopOfIntegerChecked()
        {
            //int top = int.MaxValue;
            //int next;
            //checked
            //{ next = top + 1; }
            //next = checked(top + 1);
            //Assert.IsTrue();
        }

        [TestMethod]
        //[ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void TopOfIntegerCheckedCall()
        {
            //int top = int.MaxValue;
            //int next;
            //checked
            //{ next = CalcNumber(top); }
            //Assert.IsTrue();
        }

        private int CalcNumber(int input) => input + 1;
    }

}
