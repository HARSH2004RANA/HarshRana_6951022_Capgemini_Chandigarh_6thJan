using System;

namespace AverageOfMultiplesOfFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int output = FindAverage(input1);
            Console.WriteLine(output);
        }

        static int FindAverage(int n)
        {
            
            if (n < 0)
                return -1;

            if (n > 500)
                return -2;

            int sum = 0;
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                    count++;
                }
            }

            if (count == 0)
                return 0; 

            int average = sum / count;   
            return average;
        }
    }
}
