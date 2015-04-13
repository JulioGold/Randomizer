using System;
using System.Collections.Generic;
using System.Linq;

namespace Randomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> randomizedList = args.Randomize();

            foreach (string item in randomizedList)
            {
                Console.Out.WriteLine(item);
            }
        }
    }

    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> alvo)
        {
            Random random = new Random();
            return alvo.OrderBy(x => (random.Next()));
        }
    }
}
