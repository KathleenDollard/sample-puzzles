
namespace CorePuzzles
{
    public class UnderReview
    {
        private const int expirationYears = 2;

        public static DateTime Expiration()
        {
            var now = DateTime.Now;
            return CalculateExpiration(now);
        }

        public static DateTime CalculateExpiration(DateTime startDate)
        {
            var expirationDate = startDate.AddYears(expirationYears);


            return expirationDate;
        }
    }






}
