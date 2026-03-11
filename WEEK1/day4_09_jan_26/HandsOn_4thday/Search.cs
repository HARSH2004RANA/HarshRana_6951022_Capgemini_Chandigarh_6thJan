using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOn_4thday
{
    internal class Search
    {
        static void Main()
        {
            int[] arr = { 5, 10, 15, 20, 25 };
            int search = 15;

            int output = SearchElement(arr, search);
            Console.WriteLine("Output = " + output);
        }

        static int SearchElement(int[] arr, int key)
        {
           
            if (arr == null)
                return -2;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    return -1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                   
                    return i;   
                }
            }

            return 1;
        }
    }
}
