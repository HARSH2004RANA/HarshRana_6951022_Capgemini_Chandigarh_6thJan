namespace PalindromeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine().ToLower();

            int i = 0, j = str.Length - 1;
            bool isPalindrome = true;

            while (i < j)
            {
                if (str[i] != str[j])
                {
                    isPalindrome = false;
                    break;
                }
                i++;
                j--;
            }

            if (isPalindrome)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a Palindrome");
        }
    }
}
