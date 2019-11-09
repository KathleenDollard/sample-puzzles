using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace IntrinsicTypeTests
{
    /// <summary>
    ///  Use the project BenchmarkDecimal 
    /// </summary>
    [TestClass]
    public class DecimalPerformance
    {

        private readonly string A = "Two ";
        private readonly string B = "roads ";
        private readonly string C = "diverged ";
        private readonly string D = "in a ";
        private readonly string E = "wood, ";
        private readonly string F = "and ";
        private readonly string G = "I ";
        private readonly string H = "took ";
        private readonly string I = "the one ";
        private readonly string J = "less traveled by;";
        private readonly string K = "And that has made all the difference";


        internal string AddText(string x)
        {
            x += B;
            x += C;
            x += D;
            x += E;
            x += F;
            x += G;
            x += H;
            x += I;
            x += J;
            x += K;
            return x;
        }

        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void CheckLength()
        {
            var x = AddText(A);

        }
    }
}
