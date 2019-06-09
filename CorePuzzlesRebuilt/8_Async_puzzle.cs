using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AsyncPuzzles
{
    [TestClass]
    public class _8_Async_puzzle
    {
        private const int MillisecondsDelay = 100;
        // Bacon: 4
        // Eggs: 2 * 2
        // Toast: 2
        // PourCoffee: 1
        // PourOJ: 1

        [TestMethod]
        public void OrderOfOperation()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Coffee cup = PourCoffee();
            Egg eggs = FryEggs(2);
            Bacon bacon = FryBacon(3);
            Toast toast = makeToastWithButterAndJam(2);
            Juice oj = PourOJ();

            watch.Stop();
            Console.WriteLine("Elapsed: " + watch.Elapsed);

            Toast makeToastWithButterAndJam(int number)
            {
                Toast plainToast = ToastBread(number);
                ApplyButter(plainToast);
                ApplyJam(plainToast);
                return plainToast;
            }
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring Orange Juice");
            Thread.Sleep(MillisecondsDelay);
            return new Juice();
        }

        private static void ApplyJam(Toast toast)
            => Console.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast)
            => Console.WriteLine("Putting butter on the toast");

        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }

            Console.WriteLine("Start toasting...");
            Thread.Sleep(2 * MillisecondsDelay);

            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"Putting {slices} of bacon in the pan");

            Console.WriteLine("Cooking first side of bacon...");
            Thread.Sleep(2 * MillisecondsDelay);

            for (int slice = 0; slice < slices; slice++)
                Console.WriteLine("Flipping a slice of bacon");

            Console.WriteLine("Cooking the second side of bacon...");
            Thread.Sleep(2 * MillisecondsDelay);

            Console.WriteLine("Putting bacon on plate");
            return new Bacon();
        }

        private static Egg FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Thread.Sleep(2 * MillisecondsDelay);

            Console.WriteLine($"Cracking {howMany} eggs");

            Console.WriteLine("Cooking the eggs ...");
            Thread.Sleep(2 * MillisecondsDelay);

            Console.WriteLine("Putting eggs on plate");
            return new Egg();
        }
        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            Thread.Sleep(MillisecondsDelay);
            return new Coffee();
        }

        public class Coffee
        { }

        public class Juice
        { }

        public class Egg
        { }

        public class Bacon
        { }
        public class Toast
        { }
    }
}
