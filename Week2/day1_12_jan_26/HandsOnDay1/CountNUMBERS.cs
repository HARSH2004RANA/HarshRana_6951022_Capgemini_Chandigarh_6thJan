using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnDay1
{
    internal class CountNUMBERS
    {
        static void Main()
        {
            int input = 689;  
            int output;

            if (input < 0)
            {
                output = -1;
                Console.WriteLine("Output: " + output);
                return;
            }

            int count500 = input / 500;
            input %= 500;

            int count100 = input / 100;
            input %= 100;

            int count50 = input / 50;
            input %= 50;

            int count10 = input / 10;
            input %= 10;

            int count1 = input; 

         
            output = count500 + count100 + count50 + count10 + count1;

            Console.WriteLine("500 - " + count500);
            Console.WriteLine("100 - " + count100);
            Console.WriteLine("50  - " + count50);
            Console.WriteLine("10  - " + count10);
            Console.WriteLine("1   - " + count1);

            Console.WriteLine("Output = " + output);
        }
    }
}
