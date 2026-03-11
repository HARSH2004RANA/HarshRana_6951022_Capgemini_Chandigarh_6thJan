namespace MaxConsecutiveDeletion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String: ");
            string s = Console.ReadLine();

            int deletions = 0;
            int i = 0;

            while (i < s.Length - 1)
            {
                if (s[i] == s[i + 1])
                {
                    deletions++;
                    i += 2; // skip both characters
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine("Maximum Deletions: " + deletions);
        }
    }
}
