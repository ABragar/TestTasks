using System;
using System.Linq;

namespace Task2.OrderStrategies
{
    internal class RandomOrderStrategy : IArrayReorderStrategy
    {
        public int[] Order(int[] array)
        {
            Random random = new Random();
            return array.OrderBy(x => random.Next())
                .ToArray();
        }
    }
}