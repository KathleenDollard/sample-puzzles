using System;
using System.Collections.Generic;
using System.Text;

namespace Playspace
{
    public struct Fred
    {}

    public static class GenericRefactor
    {
        public static int Filter3<T>( T input)
            where T : unmanaged
            => default;

        public static void Temp()
        {
            Filter3<int>(42);
            //Filter3<string>("");
            Filter3<Fred>(new Fred());

        }

        public static IEnumerable<T> Filter3<T>(this IEnumerable<T> input,
                     Func<T, bool> filterFunc)
            where T : unmanaged
        {
            var list = new List<T>();
            foreach (var item in input)
            {
                if (filterFunc(item))
                { list.Add(item); }
            }
            return list.ToArray();

        }

        public static IEnumerable<int> Filter3(this IEnumerable<int> input,
                       Func<int, bool> filterFunc)
        {
            var list = new List<int>();
            foreach (var item in input)
            {
                if (filterFunc(item))
                { list.Add(item); }
            }
            return list.ToArray();

        }
    }
}
