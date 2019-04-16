using System;
using System.Linq;
using static System.Console;

namespace Task2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var random = new Random(); //init randomizer
            //Get int range, order by random,
            var intArray = Enumerable.Range(1, 100000)
                .OrderBy(x => random.Next())
                .ToArray();

            //Find duplicates
            if (intArray.GroupBy(x => x)
                .Where(x => x.Count() > 1)
                .Select(x => x.Key)
                .Any())
            {
                throw new Exception("There are duplicates in result array found");
            }
            WriteLine("Press any key to continue");
            ReadKey();
        }
    }
}