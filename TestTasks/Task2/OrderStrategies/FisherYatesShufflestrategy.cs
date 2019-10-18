using System;

namespace Task2.OrderStrategies
{
    internal class FisherYatesShufflestrategy : IArrayReorderStrategy
    {
        public int[] Order(int[] array)
        {
            var random = new Random();
            for (int i = 1; i <= array.Length - 1; i++)
            {
                var swapIdx = random.Next(i + 1);
                var tmp = array[swapIdx];
                array[swapIdx] = array[i];
                array[i] = tmp;
            }
            return array;
        }
    }
}