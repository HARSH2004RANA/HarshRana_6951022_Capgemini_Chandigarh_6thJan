namespace ListTheElementOfA
{
    class UserProgramCode
    {
        public static List<int> GetElements(List<int> input1, int input2)
        {
            List<int> result = new List<int>();

            foreach (int num in input1)
            {
                if (num < input2)
                {
                    result.Add(num);
                }
            }

            if (result.Count == 0)
            {
                result.Add(-1);
                return result;
            }

            // Sort in descending order
            result.Sort();
            result.Reverse();

            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> input1 = new List<int>();

            for (int i = 0; i < n; i++)
            {
                input1.Add(int.Parse(Console.ReadLine()));
            }

            int input2 = int.Parse(Console.ReadLine());

            List<int> result = UserProgramCode.GetElements(input1, input2);

            if (result.Count == 1 && result[0] == -1)
            {
                Console.WriteLine("No element found");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
