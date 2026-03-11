namespace LuckyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();

            if (n > str.Length)
            {
                Console.WriteLine("Invalid");
                return;
            }

            bool isLucky = false;

            for (int i = 0; i <= str.Length - n; i++)
            {
                string sub = str.Substring(i, n);

                // Check only P, S, G are present
                bool validChars = true;
                foreach (char c in sub)
                {
                    if (c != 'P' && c != 'S' && c != 'G')
                    {
                        validChars = false;
                        break;
                    }
                }

                if (!validChars)
                    continue;

                // Check for at least n/2 consecutive P or S or G
                int maxCount = 1, count = 1;

                for (int j = 1; j < sub.Length; j++)
                {
                    if (sub[j] == sub[j - 1])
                    {
                        count++;
                        maxCount = Math.Max(maxCount, count);
                    }
                    else
                    {
                        count = 1;
                    }
                }

                if (maxCount >= n / 2)
                {
                    isLucky = true;
                    break;
                }
            }

            Console.WriteLine(isLucky ? "Yes" : "No");
        }
    }
}
