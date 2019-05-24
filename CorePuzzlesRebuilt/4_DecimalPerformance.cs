using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace IntrinsicTypeTests
{
    [TestClass]
   public class FloatingPointPerformance
   {
      private int iterations = 100_000_000;

      [TestMethod]
      public void singleTest()
      {
         Stopwatch watch = new Stopwatch();
         watch.Start();
         Single z = 0;
         for (int i = 0; i < iterations; i++)
         {
            Single x = i;
            Single y = x * i;
            z += y;
         }
         watch.Stop();
         Console.WriteLine("Single" + watch.Elapsed);
         Console.WriteLine(z);
      }

      [TestMethod]
      public void emptyTest()
      {
         Stopwatch watch = new Stopwatch();
         watch.Start();
         for (int i = 0; i < iterations; i++)
         {
         }
         watch.Stop();
         Console.WriteLine("Empty: " + watch.Elapsed);
      }
      [TestMethod]
      public void emptySingleTest()
      {
         Stopwatch watch = new Stopwatch();
         watch.Start();
         Single y = 0;
         for (int i = 0; i < iterations; i++)
         {
            y = i;
         }
         watch.Stop();
         Console.WriteLine("Integer" + watch.Elapsed);
         Console.WriteLine(y);
      }

      [TestMethod]
      public void emptyDoubleTest()
      {
         Stopwatch watch = new Stopwatch();
         watch.Start();
         Double y = 0;
         for (int i = 0; i < iterations; i++)
         {
            y = i;
         }
         watch.Stop();
         Console.WriteLine("Empty Double: " + watch.Elapsed);
         Console.WriteLine(y);
      }

      [TestMethod]
      public void emptyDecimalTest()
      {
         Stopwatch watch = new Stopwatch();
         watch.Start();
         Decimal y = 0;
         for (int i = 0; i < iterations; i++)
         {
            y = i;
         }
         watch.Stop();
         Console.WriteLine("Empty Decimal: " + watch.Elapsed);
         Console.WriteLine(y);
      }

      [TestMethod]
      public void doubleTest()
      {
         Stopwatch watch = new Stopwatch();
         watch.Start();
         Double z = 0;
         for (int i = 0; i < iterations; i++)
         {
            Double x = i;
            Double y = x * i;
            z += y;
         }
         watch.Stop();
         Console.WriteLine("Double: " + watch.Elapsed);
         Console.WriteLine(z);
      }

      [TestMethod]
      public void decimalTest()
      {
         Stopwatch watch = new Stopwatch();
         watch.Start();
         Decimal z = 0;
         for (int i = 0; i < iterations; i++)
         {
            Decimal x = i;
            Decimal y = x * i;
            z += y;
         }
         watch.Stop();
         Console.WriteLine("Decimal: " + watch.Elapsed);
         Console.WriteLine(z);
      }
   }
}
