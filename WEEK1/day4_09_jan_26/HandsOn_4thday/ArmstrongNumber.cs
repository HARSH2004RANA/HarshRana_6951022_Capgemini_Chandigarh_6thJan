using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HandsOn_4thday
{
    internal class ArmstrongNumber
    {
        public int CheckArmstrong(int n)
        {
            int output1;
            if (n < 0)
            {
                output1 = -1;
            }
            else if (n > 999)
            {
                output1 = -2;
            }
            else
            {
                int count = 0;
                int temp = n;
                while (temp > 0)
                {
                    count++;
                    temp /= 10;
                }

                temp = n;

                int digit, sum = 0;
                while (temp > 0)
                {
                    digit = temp % 10;
                    sum += (int)Math.Pow(digit, count);
                    temp /= 10;
                }
                if (sum == n) output1 = 1;
                else output1 = 0;
            }
                return output1;
        }
        public static void Main(string[] args)
        {
            ArmstrongNumber An = new ArmstrongNumber();
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(An.CheckArmstrong(n));

        }
    }
}
