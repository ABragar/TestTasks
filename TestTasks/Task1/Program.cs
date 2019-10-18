using System;
using static System.Console;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var isFoo = (i % 3 == 0);
                var isBar = (i % 5 == 0);
                
                if (isFoo)
                {
                    Write("Foo");
                }
                
                if (isBar)
                {
                    Write("Bar");
                }
                
                if(!(isFoo || isBar))
                {
                    Write(i);
                }
                Write(Environment.NewLine);
            }
            ReadKey();
        }
    }
}