namespace Donations
{
    class UserProgramCode
    {
        public static int getDonation(string[] input1, int input2)
        {
            HashSet<string> set = new HashSet<string>();
            int totalDonation = 0;

            foreach (string s in input1)
            {
                // Business Rule 2: Check for special characters
                foreach (char c in s)
                {
                    if (!char.IsDigit(c))
                    {
                        return -2;
                    }
                }

                // Business Rule 1: Check for duplicates
                if (!set.Add(s))
                {
                    return -1;
                }

                // Extract location code and donation amount
                int locationCode = int.Parse(s.Substring(3, 3));
                int donation = int.Parse(s.Substring(6, 3));

                if (locationCode == input2)
                {
                    totalDonation += donation;
                }
            }

            return totalDonation;
        }
    }

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] input1 = new string[n];
            for (int i = 0; i < n; i++)
            {
                input1[i] = Console.ReadLine();
            }

            int input2 = int.Parse(Console.ReadLine());

            int result = UserProgramCode.getDonation(input1, input2);
            Console.WriteLine(result);
        }
    }
}
