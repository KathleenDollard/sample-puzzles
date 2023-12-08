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
            int[] x1 = new int[] { 1, 2, 3, 4 };
            int[] x2 = Array.Empty<int>();
            WriteByteArray(new[] { (byte)1, (byte)2, (byte)3 });
            List<int> x4 = new() { 1, 2, 3, 4 };
            Span<DateTime> dates = stackalloc DateTime[] { GetDate(0), GetDate(1) };
            WriteByteSpan(stackalloc[] { (byte)1, (byte)2, (byte)3 });

            // local functions lets you organize methods without 
            // exposing these functions for unexpected use or to 
            // clutter IntelliSense
            static void WriteByteSpan(Span<byte> span) { }

            static void WriteByteArray(byte[] bytes) { }

            static DateTime GetDate(int i) => DateTime.Now;
        }
    }
}
