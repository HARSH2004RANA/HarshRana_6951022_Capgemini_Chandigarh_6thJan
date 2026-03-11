using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOn_4thday
{
    internal class Repeat
    {
        static void Main()
        {
            int[] input1 = { 2, 2, 2, 2, 3, 3, 3, 3, 4 };
            int[] result1 = FindMostRepeated(input1);
            PrintArray(result1);

            int[] input2 = { 2, 2, 2, 3, 3, 4 };
            int[] result2 = FindMostRepeated(input2);
            Console.WriteLine(true);
            PrintArray(result2);
        }

        static int[] FindMostRepeated(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return new int[0];

            
            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach (int x in arr)
            {
                if (freq.ContainsKey(x))
                    freq[x]++;
                else
                    freq[x] = 1;
            }

            int maxCount = 0;
            foreach (var item in freq)
            {
                if (item.Value > maxCount)
                    maxCount = item.Value;
            }

            List<int> output = new List<int>();
            foreach (var item in freq)
            {
                if (item.Value == maxCount)
                    output.Add(item.Key);
            }

            return output.ToArray();
        }

        static void PrintArray(int[] arr)
        {
            Console.Write("Output = { ");
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("}");
        }
    }
}
