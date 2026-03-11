using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOn_4thday
{
    internal class Sum
    {
        static void Main()
        {
            
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            int output1 = FindAverageSum(arr);
            Console.WriteLine("Output1 = " + output1);
        }

        static int FindAverageSum(int[] arr)
        {
            
            if (arr == null || arr.Length < 0)
            {
                return -2;
            }

            int evenSum = 0;
            int oddSum = 0;

            foreach (int num in arr)
            {
                // Condition 1: If any element is negative
                if (num < 0)
                {
                    return -1;
                }

                if (num % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }

            
            int output1 = (evenSum + oddSum) / 2;
            return output1;
        }
    }
}
