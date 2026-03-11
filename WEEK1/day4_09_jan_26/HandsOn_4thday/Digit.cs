using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOn_4thday
{
    internal class Digit
    {
        static void Main()
        {
            int number;
            int output1;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                output1 = -1;
            }
            else
            {

                if (number == 0)
                {
                    output1 = 1;
                }
                else
                {
                    output1 = 0;
                    while (number > 0)
                    {
                        number = number / 10;
                        output1++;
                    }
                }
            }

            Console.WriteLine("Output1 = " + output1);
        }

    }
}
