using System;
using static System.Console;

namespace Task6
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            var originalArray = new string[]
            {
                Colours.Red,
                Colours.Green,
                Colours.Yellow,
                Colours.Blue,
                Colours.Purple
            };

            WriteLine("Array before rearrange");
            Array.ForEach(originalArray, item => WriteLine(item));

            var rearrangeFromItem = Colours.Yellow;
            var rearrangedArray = originalArray.ReArrangeFrom(rearrangeFromItem);

            WriteLine($"Rearranged array from {rearrangeFromItem} item");
            Array.ForEach(rearrangedArray, item => WriteLine(item));

            WriteLine("Press any key to continue");
            ReadKey();
        }
    }
}