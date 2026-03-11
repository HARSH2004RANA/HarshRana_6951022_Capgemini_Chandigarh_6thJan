using System;
using System.Linq;

namespace SearchRemoveAndSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 54, 26, 78, 32, 55 };
            int input2 = 5;
            int input3 = 78;

            int[] output = ProcessArray(input1, input2, input3);

            Console.WriteLine("Output:");
            foreach (int i in output)
                Console.Write(i + " ");
        }

        static int[] ProcessArray(int[] arr, int size, int search)
        {
           
            if (size < 0)
                return new int[] { -2 };

            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                    return new int[] { -1 };
            }

            bool found = false;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == search)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
                return new int[] { -3 };

       
            int[] result = arr.Where(x => x != search).ToArray();
            Array.Sort(result);

            return result;
        }
    }
}
