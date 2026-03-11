using System;

namespace SearchElementInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 7, 3, 9, 2 };
            int size = arr.Length;
            int search = 9;

            int result = Search(arr, size, search);
            Console.WriteLine(result);
        }

        static int Search(int[] arr, int size, int search)
        {
            if (size < 0)
                return -2;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                    return -1;
            }

            for (int i = 0; i < size; i++)
            {
                if (arr[i] == search)
                    return 1;   
            }

            return -3;
        }
    }
}
