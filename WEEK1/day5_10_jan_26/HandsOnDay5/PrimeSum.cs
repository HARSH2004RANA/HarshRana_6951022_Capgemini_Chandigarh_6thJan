using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnDay5
{
    internal class PrimeSum
    {
        static void Main()
        {
            int[] input1 = { 1, 2, 3, 4, 5 };
            int input2 = 5;  

            int output1 = SumOfPrimes(input1, input2);
            Console.WriteLine("Output = " + output1);
        }

        static int SumOfPrimes(int[] arr, int size)
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

            int sum = 0;
            bool foundPrime = false;

            for (int i = 0; i < size; i++)
            {
                if (IsPrime(arr[i]))
                {
                    sum += arr[i];
                    foundPrime = true;
                }
            }

            if (!foundPrime)
                return -3;

            return sum;
        }

        static bool IsPrime(int num)
        {
            if (num <= 1)   
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
