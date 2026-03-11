namespace Palindrom
{
    internal class Program
    {
       

        static int IsPalindrome(int num)
        {
            if (num < 0) return -1;

            int temp = num, rev = 0;

            while (temp > 0)
            {
                rev = rev * 10 + temp % 10;
                temp /= 10;
            }

            if (rev == num) return 1;
            return -2;
        }

        static void Main()
        {
            

            int number = 121;
            int palindromeResult = IsPalindrome(number);
            Console.WriteLine(palindromeResult);
        }

    }
}
