using System;

namespace HalfAscHalfDescSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 9, 1, 7, 3, 6, 2, 8 };
            int size = arr.Length;

            if (size < 0)
            {
                arr = new int[] { -1 };
            }
            else
            {
                int mid = size / 2;

                Array.Sort(arr, 0, mid);

                Array.Sort(arr, mid, size - mid);
                Array.Reverse(arr, mid, size - mid);
            }

            Console.WriteLine("Half Ascending and Half Descending:");
            foreach (int i in arr)
                Console.Write(i + " ");
        }
    }
}
