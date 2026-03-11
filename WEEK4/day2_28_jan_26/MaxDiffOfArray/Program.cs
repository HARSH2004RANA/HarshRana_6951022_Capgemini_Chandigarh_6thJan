namespace MaxDiffOfArray
{
    class UserProgramCode
    {
        public static int diffIntArray(int[] input1)
        {
            int n = input1.Length;

            // Rule 2: Size check
            if (n == 1 || n > 10)
            {
                return -2;
            }

            HashSet<int> set = new HashSet<int>();

            // Rule 1 & Rule 3 checks
            foreach (int num in input1)
            {
                if (num < 0)
                {
                    return -1;
                }

                if (!set.Add(num))
                {
                    return -3;
                }
            }

            int minElement = input1[0];
            int maxDiff = input1[1] - input1[0];

            for (int i = 1; i < n; i++)
            {
                maxDiff = Math.Max(maxDiff, input1[i] - minElement);
                minElement = Math.Min(minElement, input1[i]);
            }

            return maxDiff;
        }
    }

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] input1 = new int[n];

            for (int i = 0; i < n; i++)
            {
                input1[i] = int.Parse(Console.ReadLine());
            }

            int result = UserProgramCode.diffIntArray(input1);
            Console.WriteLine(result);
        }
    }
}
