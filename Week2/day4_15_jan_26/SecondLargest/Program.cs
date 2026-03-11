namespace SecondLargest
{
    internal class Program
    {
        static int FindSecondLargest(int[] input1, int input3)
        {
            
            if (input3 < 0)
            {
                return -2;
            }

            for (int i = 0; i < input3; i++)
            {
                if (input1[i] < 0)
                {
                    return -1;
                }
            }

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            for (int i = 0; i < input3; i++)
            {
                if (input1[i] > largest)
                {
                    secondLargest = largest;
                    largest = input1[i];
                }
                else if (input1[i] > secondLargest && input1[i] != largest)
                {
                    secondLargest = input1[i];
                }
            }

            return secondLargest;
        }

        static void Main(string[] args)
        {
            int[] input1 = { 2, 3, 4, 1, 9 };
            int input3 = input1.Length;

            int output1 = FindSecondLargest(input1, input3);

            Console.WriteLine("Second Largest Element:");
            Console.WriteLine(output1);

            Console.ReadLine();
        }
        
    }
}
