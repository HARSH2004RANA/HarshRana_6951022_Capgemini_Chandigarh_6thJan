using System.Text;

namespace MahirlandAlphabetsandVowels
{
    internal class Program
    {
        static bool IsVowel(char c)
        {
            c = char.ToLower(c);
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }

        static void Main()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            
            string s2Lower = s2.ToLower();

            StringBuilder filtered = new StringBuilder();

            
            foreach (char ch in s1)
            {
                char lower = char.ToLower(ch);

                
                if (!IsVowel(lower) && s2Lower.Contains(lower))
                    continue;

                filtered.Append(ch);
            }

            StringBuilder result = new StringBuilder();

            if (filtered.Length > 0)
            {
                result.Append(filtered[0]);

                for (int i = 1; i < filtered.Length; i++)
                {
                    if (char.ToLower(filtered[i]) != char.ToLower(filtered[i - 1]))
                    {
                        result.Append(filtered[i]);
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }
        }
}
