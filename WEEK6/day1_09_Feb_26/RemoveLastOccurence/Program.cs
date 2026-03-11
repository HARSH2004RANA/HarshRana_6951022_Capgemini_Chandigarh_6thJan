namespace RemoveLastOccurence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            string target=Console.ReadLine();
            string ans = "";
            int lastOccurence = -1;
            string[] st=input.Split(' ');
            for(int i=0; i<st.Length; i++)
            {
                if (st[i] == target)
                {
                    lastOccurence = i;
                }
            }
            for (int i = 0; i < st.Length; i++)
            {

                if (i== lastOccurence)
                {
                    continue;
                }
                ans += st[i];
                ans += " ";
            }
            ans.Trim(); 
            Console.WriteLine(ans);
        }
    }
}
