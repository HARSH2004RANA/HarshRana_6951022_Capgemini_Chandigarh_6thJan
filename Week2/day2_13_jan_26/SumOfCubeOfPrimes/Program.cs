using System;

namespace SumOfCubeOfPrimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int result = SumOfCubePrime(input);
            Console.WriteLine(result);
        }

        static int SumOfCubePrime(int n)
        {
           
            if (n < 0)
                return -1;

            if (n > 32767)
                return -2;

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
            if (num <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
