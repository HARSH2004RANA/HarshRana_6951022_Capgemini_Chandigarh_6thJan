using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnDay1
{
    internal class SumOfCube
    {
        static void Main()
        {
            int n = 10;   
            long output;

            if (n < 0)
            {
                output = -1;
            }
            else if (n > 32676)
            {
                output = -2;
            }
            else
            {
                output = SumOfCubesOfPrimes(n);
            }

            Console.WriteLine("Output: " + output);
        }

        static long SumOfCubesOfPrimes(int n)
        {
            long sum = 0;

            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    sum += (long)i * i * i;   
                }
            }

            return sum;
        }

        static bool IsPrime(int num)
        {
            if (num < 2)
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
