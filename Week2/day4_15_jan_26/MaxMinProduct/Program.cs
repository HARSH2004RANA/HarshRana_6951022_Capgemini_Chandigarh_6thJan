namespace MaxMinProduct
{
    internal class Program
    {
        static int FindProduct(int[] input1, int input3)
        {
            if (input3 < 0) return -2;

            for (int i = 0; i < input3; i++)
                if (input1[i] < 0)
                    return -1;

            int max = input1[0];
            int min = input1[0];

            for (int i = 1; i < input3; i++)
            {
                if (input1[i] > max) max = input1[i];
                if (input1[i] < min) min = input1[i];
            }

            return max * min;
        }

        static public void Main()
        {
            int[] input1 = { 2, 5, 1, 9, 4 };
            int input3 = input1.Length;

            int output1 = FindProduct(input1, input3);

            Console.WriteLine(output1);
        }
    }
}
