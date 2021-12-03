using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace Playspace
{
    [TestClass]
    public class BreakfastTest
    {
        [TestMethod]
        public void MakeBreakfastSync()
        {
            BreakfastSync.MakeBreakfast();
        }

        [TestMethod]
        public async Task MakeBreakfastASyncAsync()
        {
            try
            {
                Task t = BreakfastASync.MakeBreakfastAsync();
                await t;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops");
            }
        }


        [TestMethod]
        public async Task Test()
        {
            Task t = Task.Delay(1000);
            await t;
        }

        [TestMethod]
        public  void Test2()
        {
            _ = Task.Delay(1000);
        }

    }
}
