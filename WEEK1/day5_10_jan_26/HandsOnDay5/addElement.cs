using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnDay5
{
    internal class addElement
    {
        static void Main()
        {
            int[] input1 = { 21, 23, 41, 4 };
            int[] input2 = { 3, 4, 1, 5 };
            int input3 = 4;

            int[] output = AddArrays(input1, input2, input3);

            Console.Write("OUTPUT = { ");
            foreach (int x in output)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("}");
        }

        static int[] AddArrays(int[] arr1, int[] arr2, int size)
        {
            
            if (size < 0 || arr1 == null || arr2 == null)
            {
                return new int[] { -2 };
            }

            int[] output = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (arr1[i] < 0 || arr2[i] < 0)
                {
                    output[0] = -1;
                    return output;
                }
            }

            
            for (int i = 0; i < size; i++)
            {
                output[i] = arr1[i] + arr2[size - 1 - i];
            }

            return output;
        }
    }
}
