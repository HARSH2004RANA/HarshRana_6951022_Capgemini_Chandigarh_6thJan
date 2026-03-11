namespace ShipStory
{
    internal class Program
    {
        static int[] Calculate(int[] input1, int[] input2, int input3)
        {
            if (input3 < 0) return new int[] { -2 };

            for (int i = 0; i < input3; i++)
                if (input1[i] < 0 || input2[i] < 0)
                    return new int[] { -1 };

            int[] output1 = new int[input3];

            for (int i = 0; i < input3; i++)
                output1[i] = input1[i] + input2[input3 - 1 - i];

            return output1;
        }

        static public void Main()
        {
            int[] input1 = { 1, 2, 3, 4 };
            int[] input2 = { 4, 3, 2, 1 };
            int input3 = 4;

            int[] result = Calculate(input1, input2, input3);

            foreach (int i in result)
                Console.Write(i + " ");
        }
    }
}
