namespace FirstOccurencerEPLACE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string ans = "";
            string[] str = input.Split(' ');
            int firstOccurence = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == input2)
                {
                    firstOccurence = i;
                    break;
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (i == firstOccurence)
                {
                    ans += input3;
                    ans += " ";
                    continue;
                }
                ans += str[i];
                ans += " ";
            }
            ans.Trim();
            Console.WriteLine(ans);
        }
    }
}
