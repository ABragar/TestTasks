using System.Threading.Tasks;
using static System.Console;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //loop from 1 to 100, check the remainder of dividing i by 3, i by 5.
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    WriteLine("Foo");
                }
                else if (i % 5 == 0)
                {
                    WriteLine("Bar");
                }
                else
                {
                    WriteLine(i);
                }
            }
            ReadKey();
        }
    }
}