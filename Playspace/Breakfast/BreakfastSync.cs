using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Playspace
{
    public class BreakfastSync
    {
        public static void MakeBreakfast()
        {
            Coffee cup = PourCoffee();
            Egg eggs = FryEggs(2);
            Bacon bacon = FryBacon(3);
            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Juice oj = PourOJ();

            Console.WriteLine("Breakfast is ready!");
        }

        private static Juice PourOJ()
        {
            Thread.Sleep(100);
            return new Juice();
        }

        private static Toast ToastBread(int v)
        {
            Thread.Sleep(v * 1000);
            return new Toast();
        }
 
        private static Egg FryEggs(int v)
        {
            Thread.Sleep(v * 1000);
            return new Egg();
        } 
        
        private static Bacon FryBacon(int v)
        {
            Thread.Sleep(v * 2000);
            return new Bacon();
        }


        private static Coffee PourCoffee()
        {
            Thread.Sleep(1000);
            return new Coffee();
        }

        private static void ApplyJam(Toast toast) 
            => Thread.Sleep(1000);

        private static void ApplyButter(Toast toast)
            => Thread.Sleep(500);

    }
}
