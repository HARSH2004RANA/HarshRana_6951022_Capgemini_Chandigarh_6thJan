using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnDay5
{
    internal class CubeOFPrime
    {
        static void Main()
        {
            int n = 7;   
            int output = SumOfCubeOfPrimes(n);
            Console.WriteLine("Output = " + output);
        }

        static int SumOfCubeOfPrimes(int n)
        {
            
            if (n < 0 || n > 7)
                return -1;

            int sum = 0;

            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    sum += i * i * i;   
                }
            }

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
