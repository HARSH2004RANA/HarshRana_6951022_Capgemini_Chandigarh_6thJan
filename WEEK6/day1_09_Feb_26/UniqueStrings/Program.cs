namespace UniqueStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> L = ["listen", "silent", "hello", "world", "abc", "cba"];
            for (int i = 0; i < L.Count; i++)
            {
                char[] ch = L[i].ToCharArray();
                ch.Sort();
                string s = new string(ch);
                L[i] = s;
            }
            Dictionary<string,int> d= new Dictionary<string,int>();
            for(int i = 0; i < L.Count; i++)
            {
                if (!d.ContainsKey(L[i]))
                {
                    d[L[i]] = 1;
                }
                else
                {
                    d[L[i]]++;
                }
            }
            for (int i = 0; i < L.Count; i++)
            {
                if (d[L[i]]!=1)
                {
                    Console.WriteLine(L[i]);
                }
            }
        }
    }
}
