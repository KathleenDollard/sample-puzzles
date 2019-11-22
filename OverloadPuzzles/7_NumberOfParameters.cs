using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadPuzzles
{
    [TestClass]
    public class DefaultParametersAndOverloadSelection
    {
        [TestMethod]
        public void DefaultParameters()
        {
            var Int32 = 42;
            short Int16 = 42;

            // Does this compile?
            Assert.IsTrue(Test(Int32).StartsWith("OneParam"));
            Assert.IsTrue(Test(Int16).StartsWith("OneParamShort"));
        }
        public string Test(int first) => "OneParam";
        public string Test(int first, int second = 0) => "TwoParam";
        public string Test(short first, int second = 0) => "OneParamShort";
    }
}
