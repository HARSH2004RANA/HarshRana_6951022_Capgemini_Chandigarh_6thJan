using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnDay1
{
    internal class RemoveRepeat
    {
        static void Main()
        {
            int[] input = { 1, 2, 2, 3, 4, 4, 5 };

            int[] output = RemoveRepeatedElements(input);

            Console.Write("Output = { ");
            foreach (int x in output)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("}");
        }

        static int[] RemoveRepeatedElements(int[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    return new int[] { -1 };
                }
            }

            List<int> result = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!result.Contains(arr[i]))
                {
                    result.Add(arr[i]);
                }
            }

            return result.ToArray();
        }

    }
}
