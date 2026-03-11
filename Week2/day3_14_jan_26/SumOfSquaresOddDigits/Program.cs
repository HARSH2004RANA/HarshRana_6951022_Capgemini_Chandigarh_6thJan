using System;

namespace SumOfSquaresOddDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            
            if (input < 0)
            {
                Console.WriteLine(-1);
                return;
            }

            int sum = 0;
            while (input > 0)
            {
                int digit = input % 10;  
                if (digit % 2 != 0)       
                {
                    sum += digit * digit; 
                }

                input /= 10;              
            }

            Console.WriteLine(sum);
        }
    }
}
