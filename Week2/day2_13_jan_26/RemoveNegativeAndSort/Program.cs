using System;
using System.Linq;

namespace RemoveNegativeAndSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, -2, 8, -1, 3, 10 };
            int size = arr.Length;

            if (size < 0)
            {
                arr = new int[] { -1 };
            }
            else
            {
                
                arr = arr.Where(x => x >= 0).ToArray();

                Array.Sort(arr);
            }

            Console.WriteLine("After removing negatives and sorting:");
            foreach (int i in arr)
                Console.Write(i + " ");
        }
    }
}
