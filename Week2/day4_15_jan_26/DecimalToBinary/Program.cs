namespace DecimalToBinary
{
    internal class Program
    {
        static int[] Convert(int input1)
        {
            if (input1 < 0) return new int[] { -1 };

            int[] temp = new int[32];
            int index = 0;

            while (input1 > 0)
            {
                temp[index++] = input1 % 2;
                input1 /= 2;
            }

            int[] output = new int[index];

            for (int i = 0; i < index; i++)
                output[i] = temp[index - 1 - i];

            return output;
        }

        static void Main()
        {
            int input1 = 15;

            int[] result = Convert(input1);

            foreach (int i in result)
                Console.Write(i + " ");
        }
    }
}
