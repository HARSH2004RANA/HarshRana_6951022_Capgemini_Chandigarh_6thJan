using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnDay5
{
    internal class ProductOfDigits
    {
        static void Main()
        {
            int num = 56;   
            

            int output = CheckProductOfDigits(num);
            Console.WriteLine("Output = " + output);
        }

        static int CheckProductOfDigits(int num)
        {
            
            if (num < 0)
                return -1;

            if (num % 3 == 0 || num % 5 == 0)
                return -2;

            int product = 1;

       
            while (num > 0)
            {
                int digit = num % 10;
                product *= digit;
                num = num / 10;
            }

            
            if (product % 3 == 0 || product % 5 == 0)
                return 1;

            
            return 0;
        }
    }
}
