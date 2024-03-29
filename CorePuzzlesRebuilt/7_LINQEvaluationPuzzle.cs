﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace collections
{
    [TestClass]
    public class LINQEvaluation
    {
        private static int[] list = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private static int len = list.Count(); // 10
        private int A = 0, B = 0, C = 0, D = 0, E = 0, F = 0;

        [TestMethod]
        public void LINQEvaluationTestA()
        {
            // Goal: Determine how many times the query is evaluated
            // Method: Increment counter, ten times for each evaluation
            //         Once for every item in the list (len)
            IEnumerable<int> qA = list.Where(x => { A++; return true; });
            foreach (int x in qA) { }
            Assert.AreEqual(-1, A / len);
        }

        [TestMethod]
        public void LINQEvaluationTestB()
        {
            IEnumerable<int> qB = list.Where(x => { B++; return true; });
            Assert.AreEqual(-1, B / len);
        }



        [TestMethod]
        public void LINQEvaluationTestC()
        {
            IEnumerable<int> qC = list.Where(x => { C++; return true; });
            double avg = qC.Average();
            int count = qC.Count();
            foreach (int x in qC) { }
            Assert.AreEqual(-1, C / len);
        }

        [TestMethod]
        public void LINQEvaluationTestD()
        {
            IEnumerable<int> qD = list.Where(x => { D++; return true; });
            IEnumerable<int> qD2 = qD;
            double avg2 = qD2.Average();
            int count2 = qD2.Count();
            foreach (int x in qD2) { }
            Assert.AreEqual(-1, D / len);
        }

        [TestMethod]
        public void LINQEvaluationTestE()
        {
            IEnumerable<int> qE = list.Where(x => { E++; return true; });
            var qE2 = qE.ToList();
            double avg3 = qE2.Average();
            int count3 = qE2.Count();
            foreach (int x in qE2) { }
            Assert.AreEqual(-1, E / len);
        }





        [TestMethod]
        public void LINQEvaluationTestF()
        {
            IEnumerable<int> qF = list.Where(x => { F++; return true; });
            for (int i = 0; i < qF.Count(); i++) { }
            Assert.AreEqual(-1, F / len);
        }
    }
}
