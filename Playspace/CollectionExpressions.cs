using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaySpace
{
    public class CollectionExpressions
    {
        public static void F()
        {
            int[] x1 = [1, 2, 3, 4];
            int[] x2 = [];
            WriteByteArray([1, 2, 3]);
            List<int> x4 = [1, 2, 3, 4];
            Span<DateTime> dates = [GetDate(0), GetDate(1)];
            WriteByteSpan([1, 2, 3,]);
           
            //var x5 = [1,2,3, 4];

            // local functions lets you organize methods without 
            // exposing these functions for unexpected use or to 
            // clutter IntelliSense
            static void WriteByteSpan(Span<byte> span) { }

            static void WriteByteArray(byte[] bytes) { }

            static DateTime GetDate(int i) => DateTime.Now;
        }
    }
}
