using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Playspace
{
    public class BreakfastASync
    {
        public static async Task MakeBreakfastAsync()
        {
            Coffee cup = PourCoffee();
            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = makeToastWithButterAndJamAsync(2);

            var eggs = await eggsTask;
            var bacon = await baconTask;
            var toast = await toastTask;
            Juice oj = PourOJ();

            async Task<Toast> makeToastWithButterAndJamAsync(int number)
            {
                var plainToast = await ToastBreadAsync(number);
                ApplyButter(plainToast);
                ApplyJam(plainToast);
                return plainToast;
            }

            Console.WriteLine("Breakfast is ready!");
        }

        private static Juice PourOJ()
        {
            // Wait blocks
            Task.Delay(100).Wait();
            return new Juice();
        }

        private static async Task<Toast> ToastBreadAsync(int v)
        {
            await Task.Delay(v * 1000);
            return new Toast();
        }

        private static async Task<Egg> FryEggsAsync(int v)
        {
            await Task.Delay(v * 1000);
            return new Egg();
        }

        private static async Task<Bacon> FryBaconAsync(int v)
        {
            await Task.Delay(v * 2000);
            return new Bacon();
            //var tasks = new List<Task>();
            //for (int i = 0; i < v; i++)
            //{
            //    tasks.Add(Task.Delay(2000));
            //}
            //await Task.WhenAll(tasks);
            //return new Bacon();
        }


        private static Coffee PourCoffee()
        {
            // Wait blocks
            Task.Delay(1000).Wait();
            return new Coffee();
        }

        private static void ApplyJam(Toast toast)
            =>  // Wait blocks
            Task.Delay(1000).Wait();


        private static void ApplyButter(Toast toast)
            =>  // Wait blocks
            Task.Delay(500).Wait();
    }
}
