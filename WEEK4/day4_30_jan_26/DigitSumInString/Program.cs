namespace DigitSumInString
{
    public class UserProgramCode
    {
        public static int sumOfDigits(string[] input1)
        {
            int sum = 0;

            foreach (string str in input1)
            {
                foreach (char ch in str)
                {
                    if (char.IsDigit(ch))
                    {
                        sum += ch - '0';   // Convert char digit to int
                    }
                    else if (char.IsLetter(ch))
                    {
                        continue;          // Ignore alphabets
                    }
                    else
                    {
                        return -1;         // Special character found
                    }
                }
            }

            return sum;
        }
    }

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];

            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
            }

            int result = UserProgramCode.sumOfDigits(input);
            Console.WriteLine(result);
        }
    }
}
