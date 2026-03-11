namespace PasswordFromEvenOdd
{
    internal class Program
    {
        static int FindPassword(int[] input1, int input3)
        {
            if (input3 < 0) return -2;

            int sumEven = 0, sumOdd = 0;

            for (int i = 0; i < input3; i++)
            {
                if (input1[i] < 0) return -1;

                if (input1[i] % 2 == 0)
                    sumEven += input1[i];
                else
                    sumOdd += input1[i];
            }

            return (sumEven + sumOdd) / 2;
        }

        static public void Main()
        {
            int[] input1 = { 1, 2, 3, 4, 5 };
            int input3 = input1.Length;

            int output1 = FindPassword(input1, input3);
            Console.WriteLine(output1);
        }
    }
}
