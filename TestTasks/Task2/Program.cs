using System;
using System.Linq;
using Tools;
using static System.Console;

namespace Task2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           int[] intArray;
            using (new ElapsedTimeLogger("Creating random int array"))
           {
                intArray = GenerateRandomIntArray();
                CheckForDuplicates(intArray);
           }

            WriteLine("Press any key to continue");
            ReadKey();
        }

        /// <summary>
        /// Check for duplicates in array
        /// </summary>
        /// <param name="intArray"></param>
        private static void CheckForDuplicates(int[] intArray)
        {
            //Find duplicates
            if (intArray.GroupBy(x => x)
                .Where(x => x.Count() > 1)
                .Select(x => x.Key)
                .Any())
            {
                throw new Exception("There are duplicates in result array found");
            }
        }

        /// <summary>
        /// Generate array with unique numbers 1 - 100 000 in random order in it
        /// </summary>
        /// <returns></returns>
        private static int[] GenerateRandomIntArray()
        {
            var random = new Random(); //init randomizer
            //Get int range, order by random,
            return Enumerable.Range(1, 100000)
                .OrderBy(x => random.Next())
                .ToArray();


        }
    }
}