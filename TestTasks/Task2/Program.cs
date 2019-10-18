using Task2.OrderStrategies;
using static System.Console;

namespace Task2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //approach №1 using Fisher–Yates shuffle   
            int[] arr1 = new ArrayBuilder()
                .WithSize(100000)
                .WithOrderStrategey(new FisherYatesShufflestrategy())
                .Build();

            //approach №2 using Linq OrderBy 
            int[] arr2 = new ArrayBuilder()
                .WithSize(100000)
                .WithOrderStrategey(new RandomOrderStrategy())
                .Build();
            WriteLine("Done");
            ReadKey();
        }
    }
}