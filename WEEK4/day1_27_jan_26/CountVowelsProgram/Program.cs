namespace CountVowelsProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in str)
            {
                if (vowels.Contains(c))
                    count++;
            }

            Console.WriteLine("Number of vowels: " + count);
        }
    }
}
