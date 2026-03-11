using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnDay5
{
    internal class Multipleof3
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 6, 9, 10 };

            int output = CountMultiplesOf3(arr);
            Console.WriteLine("Output = " + output);
        }

        static int CountMultiplesOf3(int[] arr)
        {
            if (arr == null)
                return -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    return -1;
            }

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                    count++;
            }

            return count;
        }
    }
}
