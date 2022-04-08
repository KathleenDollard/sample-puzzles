
using System;
using System.Diagnostics;
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
            // Assert.AreEqual(s, "3.14");
        }
// Scroll down after test


















        [TestMethod]
        //[ExpectedException (typeof(Exception), AllowDerivedTypes=true)]
        public void StringInterpolationHoles2()
        {
            var x = 3.14;
            var s = x.ToString(CultureInfo.InvariantCulture);
            //Assert.AreEqual(s, "3.14");
        }

        [TestMethod]
        //[ExpectedException (typeof(Exception), AllowDerivedTypes=true)]
        public void StringInterpolationHoles3()
        {
            var x = 1;
            Debug.Assert(true,$"{x++}");
            //Assert.AreEqual(x, 1);
        }

    }
}
