using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CorePuzzles
{
    [TestClass]
    public class Context
    {
        private const int expirationYears = 2;

        [TestMethod]
        public void Test_expiration()
        {
            var testDate = DateTime.Now;
            var expires = CalculateExpiration(testDate);
            Assert.IsTrue(expires > testDate);
        }

        public DateTime CalculateExpiration(DateTime startDate)
        {
            var expirationDate = new DateTime(
                    startDate.Year + expirationYears,
                    startDate.Month, startDate.Day);
            return expirationDate;
        }
    }
}
