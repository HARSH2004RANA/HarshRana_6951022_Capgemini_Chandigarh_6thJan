using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnDay1
{
    internal class SumOfMultipleOf5
    {
        static void Main()
        {
            int input2 = 6;
            int[] input1 = { 10, 15, 3, 20, 7, 25 };

            double output;

            if (input2 < 0)
            {
                output = -2;
            }
            else
            {
              
                foreach (int x in input1)
                {
                    if (x < 0)
                    {
                        output = -1;
                        Console.WriteLine("Output: " + output);
                        return;
                    }
                }

                int sum = 0;
                int count = 0;

                for (int i = 0; i < input2; i++)
                {
                    if (input1[i] % 5 == 0)
                    {
                        sum += input1[i];
                        count++;
                    }
                }

                if (count == 0)
                    output = 0;
                else
                    output = (double)sum / count;
            }

            Console.WriteLine("Output: " + output);
        }
    }
}
