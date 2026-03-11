using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOn_4thday
{
    internal class Compare
    {
        static void Main()
        {
            int[] arr1 = { 10, 20, 30, 40 };
            int[] arr2 = { 15, 18, 35, 25 };

            int[] output = CompareArrays(arr1, arr2);

            Console.Write("Output: { ");
            foreach (int x in output)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("}");
        }

        static int[] CompareArrays(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr2 == null)
            {
                return new int[] { -2 };
            }

            int size = Math.Min(arr1.Length, arr2.Length);
            int[] output = new int[size];

            foreach (int x in arr1)
            {
                if (x < 0)
                {
                    output[0] = -1;
                    return output;
                }
            }

            foreach (int x in arr2)
            {
                if (x < 0)
                {
                    output[0] = -1;
                    return output;
                }
            }

            for (int i = 0; i < size; i++)
            {
                if (arr1[i] > arr2[i])
                    output[i] = arr1[i];
                else
                    output[i] = arr2[i];
            }

            return output;
        }
    }
}
