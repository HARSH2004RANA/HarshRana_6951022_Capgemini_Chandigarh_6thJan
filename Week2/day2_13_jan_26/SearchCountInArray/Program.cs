using System;

namespace SearchCountInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] Input1 = { 1, 2, 2, 3, 3 };
            int Input2 = 5;   
            int Input3 = 2;   
            int output = SearchAndCount(Input1, Input2, Input3);
            Console.WriteLine(output);
        }

        static int SearchAndCount(int[] arr, int size, int search)
        {
           
            if (size < 0)
                return -2;

            
            if (search < 0)
                return -3;

            
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                    return -1;
            }

            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == search)
                    count++;
            }

            return count;
        }
    }
}

