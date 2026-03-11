namespace SortAndInsert
{
    internal class Program
    {
        static int[] SortAndInsert(int[] input1, int input3, int newElement)
        {
            if (input3 < 0) return new int[] { -2 };

            for (int i = 0; i < input3; i++)
                if (input1[i] < 0)
                    return new int[] { -1 };

            Array.Sort(input1);

            int[] output = new int[input3 + 1];
            int index = 0;
            bool inserted = false;

            for (int i = 0; i < input3; i++)
            {
                if (!inserted && newElement < input1[i])
                {
                    output[index++] = newElement;
                    inserted = true;
                }
                output[index++] = input1[i];
            }

            if (!inserted)
                output[index] = newElement;

            return output;
        }

        static public void Main()
        {
            int[] input1 = { 5, 2, 8, 3 };
            int input3 = input1.Length;
            int newElement = 4;

            int[] result = SortAndInsert(input1, input3, newElement);

            foreach (int i in result)
                Console.Write(i + " ");
        }
    }
}
