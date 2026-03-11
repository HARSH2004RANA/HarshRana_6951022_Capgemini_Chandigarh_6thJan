using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnDay5
{
    internal class Perfect
    {
        static void Main()
        {
            int num = 28; 
            int output = CheckPerfect(num);
            Console.WriteLine("Output = " + output);
        }

        static int CheckPerfect(int num)
        {
            if (num < 0)
                return -2;

            int sum = 0;

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                    sum += i;
            }

            if (sum == num)
                return 1;

            return -1;
        }
    }
}
