using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Collections.Generic;

namespace methods_and_overloads
{
    [TestClass]
    public class StringBuilderPuzzle
    {
        [TestMethod]
        public void StringBuilderRace()
        {
            var iterations = 10_000_000;
            string x = null;
            GC.Collect(2, GCCollectionMode.Forced, true);
            for (int i = 0; i < iterations; i++)
            { x = Concat(); }
            var s = $"The value is {x}!!";
            Console.WriteLine("Concat literals: " + GC.GetTotalMemory(false));
            GC.Collect(2, GCCollectionMode.Forced, true);

            for (int i = 0; i < iterations; i++)
            { x = Concat("A", "B", "C", "D"); }
            s = $"The value is {x}!!";
            Console.WriteLine("Concat parameters: " + GC.GetTotalMemory(false));
            GC.Collect(2, GCCollectionMode.Forced, true);

            for (int i = 0; i < iterations; i++)
            { x = ConcatWithStringBuilder("String builder: " + "A", "B", "C", "D"); }
            s = $"The value is {x}!!";
            Console.WriteLine(GC.GetTotalMemory(false));
            GC.Collect(2, GCCollectionMode.Forced, true);
            #region Hide
            for (   int i = 0; i < iterations; i++)
            {
                x = Concat10("A", "B", "C", "D", "E", "F", "G", "H", "I", "J");
            }
            s = $"The value is {x}!!";
            Console.WriteLine("Concat lots of parameters: " + GC.GetTotalMemory(false));
            GC.Collect(2, GCCollectionMode.Forced, true);

            for (int i = 0; i < iterations; i++)
            {
                x = ConcatWithStringBuilder10("A", "B", "C", "D", "E", "F", "G", "H", "I", "J");
            }
            s = $"The value is {x}!!";
            Console.WriteLine("Lots with string builder: " + GC.GetTotalMemory(false));
            GC.Collect(2, GCCollectionMode.Forced, true);

            x = "";
            for (int i = 0; i < iterations/1000; i++)
            {
                x+= Concat10("A", "B", "C", "D", "E", "F", "G", "H", "I", "J");
            }
            s = $"The value is {x}!!";
            Console.WriteLine("Concat big/1000: " + GC.GetTotalMemory(false));
            GC.Collect(2, GCCollectionMode.Forced, true);

            var sb = new StringBuilder();          
            for (int i = 0; i < iterations/1000; i++)
            {
                sb.Append("ABCDEFGHIJ");
            }
            s = $"The value is {x}!!";
            Console.WriteLine("Stringbuilder big/1000: " + GC.GetTotalMemory(false));
            GC.Collect(2, GCCollectionMode.Forced, true);

            #endregion

        }

        private string Concat()
        {
            return "A" + "B" + "C" + "D" + "E" + "F" + "G" + "H" + "I" + "J";
        }

        private string Concat(string a, string b, string c, string d)
        {
            return a + b + c + d;
        }

        private string ConcatWithStringBuilder(string a, string b, string c, string d)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(a);
            sb.Append(b);
            sb.Append(c);
            sb.Append(d);
            return sb.ToString();
        }

        #region hide
        private string ConcatWithStringBuilder10(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(a);
            sb.Append(b);
            sb.Append(c);
            sb.Append(d);
            sb.Append(e);
            sb.Append(f);
            sb.Append(g);
            sb.Append(h);
            sb.Append(i);
            sb.Append(j);
            return sb.ToString();
        }

        private string Concat10(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
        {
            return a + b + c + d + e + f + g + h + i + j;
        }
        #endregion

        #region hide
        private void ConcatInILDASM(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
        {
            var x1 = a + b;
            var x2 = a + b + c;
            var x3 = a + b + c + d;
            var x4 = a + b + c + d + e;
            var x5 = a + b + c + d + e + f;
            var x6 = a + b + c + d + e + f + g;
            var x7 = a + b + c + d + e + f + g + h;
            var x8 = a + b + c + d + e + f + g + h + i;
            var x9 = a + b + c + d + e + f + g + h + i + j;
        }
        #endregion

    }
}
