namespace Palindrome
{
    internal class Program
    {
        public static  bool isPalindrome(string s)
        {
            int l = 0, r = s.Length - 1;
            while (l < r)
            {
                if (s[l++] != s[r--])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int score = 0;
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if((i+4)<s.Length && isPalindrome(s.Substring(i,4)))
                {

                }
            }
        }
    }
}
