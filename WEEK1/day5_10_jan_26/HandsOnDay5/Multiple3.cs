using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnDay5
{
    internal class Multiple3
    {
        static void Main()
        {
            int[] input = { 1, 2, 3, 4, 5, 6 };
            int size = 6; 
            int output = CountMultiplesOf3(input, size);
            Console.WriteLine("Output = " + output);
        }

        static int CountMultiplesOf3(int[] arr, int size)
        {
            
            if (size < 0)
                return -2;

          
            if (arr == null)
                return -2;

            
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                    return -1;
            }

            int count = 0;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 3 == 0)
                    count++;
            }

            return count;
        }
    }
}
