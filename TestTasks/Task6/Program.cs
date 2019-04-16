using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Task6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var array = new List<string> { "red", "green", "yellow", "blue", "purple" };
            WriteLine("Before");
            array.ForEach(x =>
            {
                WriteLine(x);
            });

            var newArray = ChangeStartingPoint(array.ToArray(), "blue");
            WriteLine();
            WriteLine("After");
            newArray.ForEach(x =>
            {
                WriteLine(x);
            });
            WriteLine("Press any key to continue");
            ReadKey();
        }

        private static List<string> ChangeStartingPoint(string[] array, string item)
        {
            var idx = Array.IndexOf(array, item);

            var result = new string[array.Length];

            var seg1 = new ArraySegment<string>(array, idx, array.Length - idx);

            var seg2 = new ArraySegment<string>(array, 0, idx);

            for (int i = 0; i < seg1.Count; i++)
            {
                result[i] = seg1.Array[i + seg1.Offset];
            }
            for (int i = 0; i < seg2.Count; i++)
            {
                result[i + seg1.Count] = array[i];
            }

            return result.ToList();
        }
    }
}