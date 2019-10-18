using System.Linq;

namespace Task2
{
    internal class ArrayBuilder
    {
        private int _size;
        private IArrayReorderStrategy _orderStrategy;

        internal ArrayBuilder WithSize(int size)
        {
            _size = size;
            return this;
        }

        internal ArrayBuilder WithOrderStrategey(IArrayReorderStrategy orderStrategy)
        {
            _orderStrategy = orderStrategy;
            return this;
        }

        internal int[] Build()
        {
            var result = Enumerable.Range(1, _size).ToArray();
            return _orderStrategy.Order(result);
        }
    }
}