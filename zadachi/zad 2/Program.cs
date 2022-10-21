using System;
using System.Linq;
using System.Collections.Generic;
namespace zad_2
{
    class Program
    {
        public static int Binary<T>(T[] elements, T key) where T : IComparable
        {
            int start = 0, end = elements.Count() - 1;
            while (end >= start)
            {
                int mid = (start + end) / 2;

                if (elements[mid].CompareTo(key) > 0)
                {
                    end = mid - 1;
                }
                else if (elements[mid].CompareTo(key) < 0)
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Binary(b, a));
        }
    }
}
