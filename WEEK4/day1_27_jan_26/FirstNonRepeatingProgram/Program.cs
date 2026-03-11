namespace FirstNonRepeatingProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine().ToLower();

            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq[c] = 1;
            }

            bool found = false;
            foreach (char c in str)
            {
                if (freq[c] == 1)
                {
                    Console.WriteLine("First non-repeating character: " + c);
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine("No non-repeating character found.");
        }
    }
}
