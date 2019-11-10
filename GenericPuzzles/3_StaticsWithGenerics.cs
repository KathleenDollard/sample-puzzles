using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace methods_and_overloads
{

   public class BizBase
   { public static int CounterA; }
   public class BizBase<T> : BizBase
         where T : BizBase<T>
   { public static int CounterB; }
   public class Customer : BizBase<Customer>
   { public static int CounterC; }
   public class Invoice : BizBase<Invoice>
   { public static int CounterC; }


   [TestClass]
   public class StaticGenericCounters
   {

      [TestMethod]
      public void CounterTest()
      {
         Customer.CounterC++;
         Customer.CounterC++;
         Invoice.CounterC++;
         Customer.CounterB++;
         Customer.CounterB++;
         Invoice.CounterB++;
         Customer.CounterA++;
         Customer.CounterA++;
         Invoice.CounterA++;
         //Assert.AreEqual(Customer.CounterC, -1);
         //Assert.AreEqual(Invoice.CounterC,  -1);
         //Assert.AreEqual(Customer.CounterA, -1);
         //Assert.AreEqual(Invoice.CounterA,  -1);
         //Assert.AreEqual(Customer.CounterB, -1);
         //Assert.AreEqual(Invoice.CounterB,  -1);
      }
   }
}
