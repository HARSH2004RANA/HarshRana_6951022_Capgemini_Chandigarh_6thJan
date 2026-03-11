using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOn_4thday
{
    internal class Factorial
    {
        int Factorial1(int n)
        {
            int fac = 1;
            int ans;
            if (n < 0)
            {
                ans = -1;
            }
            else if (n > 7)
            {
                ans = -2;
            }
            else
            {
                if (n == 0 || n == 1)
                {
                    ans = 1;
                }
                else
                {
                    for (int i = 2; i <= n; i++)
                    {
                        fac *= i;
                    }
                    ans = fac;
                }
            }
            return ans;
        }
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Factorial f = new Factorial();
            Console.WriteLine(f.Factorial1(n));
        }
    }
}

