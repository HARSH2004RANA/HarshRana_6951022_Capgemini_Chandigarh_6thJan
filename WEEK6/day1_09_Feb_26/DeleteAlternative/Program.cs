using System.ComponentModel;

namespace DeleteAlternative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s=Console.ReadLine();
            string ans="";
            for(int i = 0; i < s.Length; i=i+2)
            {
                ans += s[i];
            }
            Console.WriteLine(ans);
        }
    }
}
