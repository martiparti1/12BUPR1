using System;
using System.Linq;
using System.Collections.Generic;

namespace zad_1
{
    class Program
    {
        public static int Linear<T>(T[] elements, T key) where T : IComparable
        {
            for (int index = 0; index < elements.Count(); index++)
            {
                if (elements[index].CompareTo(key) == 0)
                {
                    return index;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Linear(b, a));

        }
    }
}
