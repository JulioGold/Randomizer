using System;
using System.Collections.Generic;

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
}
