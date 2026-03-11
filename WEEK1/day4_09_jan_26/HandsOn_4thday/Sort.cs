using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOn_4thday
{
    internal class Sort
    {
        static void Main()
        {
            int[] input1 = { 1, 2, 3, 4, 5 };
            int[] input2 = { 9, 8, 7, 6, 5 };

            int[] output1 = MultiplyArrays(input1, input2);

            Console.Write("Output: { ");
            foreach (int x in output1)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("}");
        }

        static int[] MultiplyArrays(int[] input1, int[] input2)
        {
            
            if (input1 == null || input2 == null)
            {
                return new int[] { -2 };
            }

            int n = input1.Length;
            int m = input2.Length;

            
            int size = Math.Min(n, m);

            int[] output = new int[size];

            
            foreach (int x in input1)
            {
                if (x < 0)
                {
                    output[0] = -1;
                    return output;
                }
            }

            foreach (int x in input2)
            {
                if (x < 0)
                {
                    output[0] = -1;
                    return output;
                }
            }

            Array.Sort(input1);

            Array.Sort(input2);
            Array.Reverse(input2);

            
            for (int i = 0; i < size; i++)
            {
                output[i] = input1[i] * input2[size - 1 - i];
            }

            return output;
        }
    }
}
