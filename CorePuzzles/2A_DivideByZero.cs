using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntrinsicTypeTests
{
    [TestClass]
    public class DivideByZero
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroInteger()
        {
            int three = 3;
            int zero = 0;
            int result = three / zero;
            //Assert.IsTrue(true); // Will this code be reached?
        }



        [TestMethod]
        //[ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroDecimal()
        {
            //decimal three = 3;
            //decimal zero = 0;
            //decimal result = three / zero;
            //Assert.IsTrue(true);
        }


        [TestMethod]
        //[ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroDouble()
        {
            double three = 3;
            double zero = 0;
            double result = three / zero;
            Assert.IsTrue(true);
        }
    }
}
