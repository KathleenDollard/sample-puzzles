using System;
using System.Collections.Generic;
using System.Text;

namespace Playspace
{
    public static class GenericRefactor
    {

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
