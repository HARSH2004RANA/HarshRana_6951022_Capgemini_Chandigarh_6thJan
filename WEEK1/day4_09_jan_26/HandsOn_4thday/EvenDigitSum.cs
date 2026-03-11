using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOn_4thday
{
    internal class EvenDigitSum
    {
        static void Main()
        {
            int number = 24891;  

            int output = SumOfEvenDigits(number);
            Console.WriteLine("Output = " + output);
        }

        static int SumOfEvenDigits(int num)
        {
            
            if (num < 0)
                return -1;

            if (num > 32767)
                return -2;

            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;

                if (digit % 2 == 0)   
                {
                    sum += digit;
                }

                num = num / 10;
            }

            return sum;
        }
    }
}
