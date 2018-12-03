using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace methods_and_overloads
{
    public class FooA
    {
        public static int i = 0;
        public static int Bar() {
            i += 1;
            return i; }
    }
    public class FooB : FooA
    {
        public static int i = 0;
        public static int Bar()
        {
            i += 1;
            return i;
        }
    }

    [TestClass]
    public class StaticCounters
    {

        [TestMethod]
        public void CounterTest()
        {
            FooA.Bar();
            FooB.Bar();
            FooA.Bar();
        
            //Assert.AreEqual(FooA.i, ?);
            //Assert.AreEqual(FooB.i, ?);

        }
    }
}
