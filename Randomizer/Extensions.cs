using System;
using System.Collections.Generic;
using System.Linq;

namespace Randomizer
{
    public static class Extensions
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> target)
        {
            Random random = new Random();

            return target.OrderBy(x => (random.Next()));
        }
    }
}
