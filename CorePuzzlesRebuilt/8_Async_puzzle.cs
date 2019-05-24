using System;
using System.Collections.Generic;
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
        private const int MillisecondsDelay = 1000;
        // Task.Delay
        // Bacon: 2
        // Eggs: 2
        // Toast: 1

        [TestMethod]
       public  void OrderOfOperation()
        {
            Coffee cup = PourCoffee();
            Egg eggs = FryEggs(2);
            Bacon bacon = FryBacon(3);
            Toast toast = makeToastWithButterAndJam(2);
            Juice oj = PourOJ();

            Toast makeToastWithButterAndJam(int number)
            {
                Toast plainToast = ToastBread(number);
                ApplyButter(plainToast);
                ApplyJam(plainToast);
                return plainToast;
            }
        }

        [TestMethod]
        public  async Task OrderOfAsyncOperation()
        {
            Coffee cup = PourCoffee();
            Task<Egg> eggsTask = FryEggsAsync(2);
            Task<Bacon> baconTask = FryBaconAsync(3);
            Task<Toast> toastTask = makeToastWithButterAndJamAsync(2);

            Egg eggs = await eggsTask;
            Bacon bacon = await baconTask;
            Toast toast = await toastTask;
            Juice oj = PourOJ();

            async Task<Toast> makeToastWithButterAndJamAsync(int number)
            {
                Toast plainToast = await ToastBreadAsync(number);
                ApplyButter(plainToast);
                ApplyJam(plainToast);
                return plainToast;
            }
        }

        [TestMethod]
        static async Task Main(string[] args)
        {
            Coffee cup = PourCoffee();
            Task<Egg> eggsTask = FryEggsAsync(2);
            Task<Bacon> baconTask = FryBaconAsync(3);
            Task<Toast> toastTask = makeToastWithButterAndJamAsync(2);

            Egg eggs = await eggsTask;
            Bacon bacon = await baconTask;
            Toast toast = await toastTask;
            Juice oj = PourOJ();

            async Task<Toast> makeToastWithButterAndJamAsync(int number)
            {
                Toast plainToast = await ToastBreadAsync(number);
                ApplyButter(plainToast);
                ApplyJam(plainToast);
                return plainToast;
            }
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring Orange Juice");
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
            Thread.Sleep(MillisecondsDelay);

            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"Putting {slices} of bacon in the pan");

            Console.WriteLine("Cooking first side of bacon...");
            Thread.Sleep(MillisecondsDelay);

            for (int slice = 0; slice < slices; slice++)
                Console.WriteLine("Flipping a slice of bacon");

            Console.WriteLine("Cooking the second side of bacon...");
            Thread.Sleep(MillisecondsDelay);

            Console.WriteLine("Putting bacon on plate");
            return new Bacon();
        }

        private static Egg FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Thread.Sleep(MillisecondsDelay);

            Console.WriteLine($"Cracking {howMany} eggs");

            Console.WriteLine("Cooking the eggs ...");
            Thread.Sleep(MillisecondsDelay);

            Console.WriteLine("Putting eggs on plate");
            return new Egg();
        }
        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
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


        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }

            Console.WriteLine("Start toasting...");
            await Task.Delay(MillisecondsDelay);

            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"Putting {slices} of bacon in the pan");

            Console.WriteLine("Cooking first side of bacon...");
            await Task.Delay(MillisecondsDelay);

            for (int slice = 0; slice < slices; slice++)
                Console.WriteLine("Flipping a slice of bacon");

            Console.WriteLine("Cooking the second side of bacon...");
            await Task.Delay(MillisecondsDelay);

            Console.WriteLine("Putting bacon on plate");
            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(MillisecondsDelay);

            Console.WriteLine($"Cracking {howMany} eggs");

            Console.WriteLine("Cooking the eggs ...");
            await Task.Delay(MillisecondsDelay);

            Console.WriteLine("Putting eggs on plate");
            return new Egg();
        }
    }
}
