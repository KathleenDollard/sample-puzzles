using System.Diagnostics;

namespace Party
{
    public class GetReady
    {
        public static long ToCelebrate()
        {
            var stopwatch = Stopwatch.StartNew();
            Yama.GetDrinks();
            Lakisha.GetFood();
            Juan.GetCakes();
            Binita.GetGifts();
            Daneen.GetHats();
            stopwatch.Stop();
            var duration = stopwatch.ElapsedMilliseconds;
            return duration;
        }
        public static T GetStuff<T>(int time)
            where T : new()
        {
            Thread.Sleep(time);
            return new T();
        }
    }
    public class Yama
    {
        public static Drinks GetDrinks() 
            => GetReady.GetStuff<Drinks>(30);
    }
    public class Lakisha
    {
        public static Food GetFood() 
            => GetReady.GetStuff<Food>(45);
    }
    public class Juan
    {
        public static Cakes GetCakes() 
            => GetReady.GetStuff<Cakes>(30);
    }
    public class Daneen
    {
        public static Hats GetHats() 
            => GetReady.GetStuff<Hats>(15);
    }
    public class Binita
    {
        public static Gifts GetGifts() 
            => GetReady.GetStuff<Gifts>(60);
    }
}
