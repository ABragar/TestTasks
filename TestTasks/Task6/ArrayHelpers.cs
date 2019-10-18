using System;

namespace Task6
{
    internal static class ArrayHelpers
    {
        public static string[] ReArrangeFrom(this string[] array, string item)
        {
            var index = Array.IndexOf(array, item);

            var result = new string[array.Length];

            var seg1 = new ArraySegment<string>(array, index, array.Length - index);

            var seg2 = new ArraySegment<string>(array, 0, index);

            seg1.ToArray().CopyTo(result, 0);

            seg2.ToArray().CopyTo(result, seg1.Offset + 1);

            return result;
        }

    }
}
