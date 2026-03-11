using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnDay5
{
    internal class Reverse
    {
        static void Main()
        {
            int[] input1 = { 12, 34, 56, 17, 2 };
            int input2 = 5;

            int[] output1 = ReplaceUsingMid(input1, input2);

            Console.Write("Output1 = { ");
            foreach (int x in output1)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("}");
        }

        static int[] ReplaceUsingMid(int[] arr, int size)
        {
            if (size < 0 || arr == null)
                return new int[] { -2 };

            int[] output = new int[size];

            if (size % 2 == 0)
            {
                output[0] = -3;
                return output;
            }

            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                {
                    output[0] = -1;
                    return output;
                }
            }

            for (int i = 0; i < size; i++)
            {
                output[i] = arr[i];
            }

            int mid = size / 2;

            for (int i = 0; i < mid; i++)
            {
                int temp = output[i];
                output[i] = output[size - 1 - i];
                output[size - 1 - i] = temp;
            }

            return output;
        }
    }
}
