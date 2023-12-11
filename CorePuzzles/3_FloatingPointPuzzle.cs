using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntrinsicTypeTests
{
    [TestClass]
    public class FloatingPoint
    {

        #region How you might encounter this
        /// <summary>
        /// Provide context for floating point puzzles
        /// </summary>
        public void CalculateCompliance()
        {
            Single[] monthlyEF = { 1, 1, 1 };
            Single[] monthlyOut = { 3, 3, 3 };
            double quarterlyCompliance = 0;
            for (int i = 0; i < 3; i++)
            { quarterlyCompliance += monthlyEF[i] / monthlyOut[i]; }
            if (quarterlyCompliance < 1)
            { }  // Out of Compliance, adjust systems!
            else if (quarterlyCompliance > 1)
            { }  // We're wasting money, adjust systems!!!
            else
            { }  // Exactly on target! Give everyone a bonus }
        }
        #endregion



        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void ReconstructPie()
        {
            float one = 1;
            Single three = 3;
            Single x = one / three;
            var result = 3 * x;
            //Assert.IsTrue(result == 1.0);
            Assert.IsTrue(result > 1.0);
            //Assert.IsTrue(result < 1.0);
        }





        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void ReconstructPie2()
        {
            Single one = 1;
            Single three = 3;
            Single x = one / three;
            var result = 3 * x;
            //Assert.IsTrue(result == 1.0);
            //Assert.IsTrue(result < 1.0);
            //Assert.IsTrue(result > 1.0);
            //Assert.IsTrue(Math.Round(result, 7) == 1);
        }




        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void ReconstructPie3()
        {
            decimal one = 1;
            decimal three = 3;
            decimal x = one / three;
            decimal result = 3 * x;
            //Assert.IsTrue(result == 1.0);
            //Assert.IsTrue(result > 1.0);
            //Assert.IsTrue(result < 1.0m);
            //Assert.IsTrue(Math.Round(result, 7) == 1);
        }



        [TestMethod]
        public void ManyPiePieces()
        {
            double x = .1;
            double result = 10 * x;
            double result2 = x + x + x + x + x + x + x + x + x + x;
            //Assert.IsTrue(result == 1);
            //Assert.IsTrue(result2 == 1);
            //Assert.IsFalse(result == result2);
        }

        [TestMethod]
        public void DoubleAddition()
        {
            double x = .1;
            double result = 10 * x;
            double result2 = x + x + x + x + x + x + x + x + x + x;

            //Console.WriteLine(result == result2);
            //Console.WriteLine("{0} - {1}", result, result2);
            //Console.WriteLine("{0:R} - {1:R}", result, result2);
        }

    }
}
