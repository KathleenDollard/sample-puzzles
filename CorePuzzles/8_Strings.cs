
using System;
using System.Globalization;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CorePuzzles
{
    [TestClass]
    public class Strings
    {
        public Strings ()
        {
            var myCI = new CultureInfo("en-US", false);

            myCI.NumberFormat.NumberDecimalSeparator = ",";
            Thread.CurrentThread.CurrentCulture = myCI;
        }

        [TestMethod]
        //[ExpectedException (typeof(Exception), AllowDerivedTypes=true)]
        public void StringInterpolationHoles()
        {
            var x = 3.14;
            var s = $"{x}";
            //Assert.IsTrue(s.Equals("3.14"));
            //Assert.IsFalse(s.Equals("3.14"));
        }

        [TestMethod]
        //[ExpectedException (typeof(Exception), AllowDerivedTypes=true)]
        public void StringInterpolationHoles2()
        {
            var x = 3.14;
            var s = string.Create(CultureInfo.InvariantCulture, $"{x}{F()}");
            //Assert.IsTrue(s.Equals("3.14"));
            //Assert.IsFalse(s.Equals("3.14"));
        }

        public int F() => 42;
    }
}
