using System.Text.RegularExpressions;

namespace GreetingValidator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Greeting: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter Name: ");
            string input2 = Console.ReadLine();

            // Regex: Name must be more than 15 characters
            string pattern = @"^Hi how are you Dear\s[A-Za-z]{16,}$";

            string fullText = input1 + " Dear " + input2;

            if (Regex.IsMatch(fullText, pattern))
            {
                Console.WriteLine("Valid Pattern");
            }
            else
            {
                Console.WriteLine("Invalid Pattern (Name must be > 15 characters)");
            }

            Console.WriteLine("Output: " + input1 + " " + input2);
        }
    }
}
