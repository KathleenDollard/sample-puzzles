using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IntrinsicTypeTests
{
    [TestClass]
    public class Division
    {

        public void test()
        {
            var discount = CalucateDiscount(30, 20, 30);
        }


        public int CalucateDiscount(int maxDiscountPercent, 
            int markupPercent, int niceFactor)
        {
            int discount = maxDiscountPercent * (markupPercent / niceFactor);
            return discount;
        }



        [TestMethod]
        //[ExpectedException (typeof(Exception), AllowDerivedTypes=true)]
        public void DivisionTest()
        {
            int maxDiscountPercent = 30;
            int markupPercent = 20;
            int niceFactor = 30;
            double discount =
                maxDiscountPercent * (markupPercent / niceFactor);
            //Assert.IsTrue(0 == discount);
            //Assert.IsTrue(10 == discount);
            //Assert.IsTrue(20 == discount);
            //Assert.IsTrue(30 == discount);
        }








        [TestMethod]
        //[ExpectedException (typeof(Exception), AllowDerivedTypes=true)]
        public void DivisionTest2()
        {
            int maxDiscountPercent = 30;
            double markupPercent = 20;
            int niceFactor = 30;
            double discount = maxDiscountPercent * (markupPercent / niceFactor);
            //Assert.IsTrue(0 == discount);
            //Assert.IsTrue(10 == discount);
            //Assert.IsTrue(20 == discount);
            //Assert.IsTrue(30 == discount);
        }

        [TestMethod]
        //[ExpectedException(typeof(DivideByZeroException))]
        public void DivisionTest3()
        {
            int x = 9; int y = 10; int z = 100;
            if (x == 0 || y == 0) { throw new InvalidOperationException(); }
            decimal interim = x / y;
            decimal result = z / interim;
            //Assert.AreEqual(??, ??);
        }

        [TestMethod]
        //[ExpectedException (typeof(Exception), AllowDerivedTypes=true)]
        public void DivisionTestDecimal()
        {
            int maxDiscountPercent = 30;
            decimal markupPercent = 20;
            int niceFactor = 30;
            decimal discount = maxDiscountPercent * (markupPercent / niceFactor);
            //Assert.IsTrue(0 == discount);
            //Assert.IsTrue(10 == discount);
            //Assert.IsFalse(20 == discount);
            //Assert.IsTrue(20 == Math.Round(discount));
            //Assert.IsTrue(30 == discount);
        }

        [TestMethod]
        //[ExpectedException (typeof(Exception), AllowDerivedTypes=true)]
        public void DivisionTestDouble()
        {
            int maxDiscountPercent = 30;
            double markupPercent = 20;
            int niceFactor = 30;
            double discount = maxDiscountPercent * (markupPercent / niceFactor);
            //Assert.IsTrue(0 == discount);
            //Assert.IsTrue(10 == discount);
            //Assert.IsTrue(20 == discount);
            //Assert.IsTrue(30 == discount);
        }

    }
}
