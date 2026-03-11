using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnDay1
{
    internal class PositiveSort
    {
        static void Main()
        {
            int input2 = 4; 
            int[] input1 = { 20, -10, 4, 78 };

            if (input2 < 0)
            {
                Console.WriteLine("-1");
                return;
            }

            List<int> result = new List<int>();

            for (int i = 0; i < input2; i++)
            {
                if (input1[i] >= 0)
                {
                    result.Add(input1[i]);
                }
            }

            result.Sort();

            Console.Write("Output: {");
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i]);
                if (i < result.Count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("}");
        }
    }
}
