namespace maxDeletion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> st=new Stack<char>();
            int count = 0;
            string s=Console.ReadLine();
            foreach(char c in s)
            {
                if (st.Count()!=0 && st.Peek() == c)
                {
                    st.Pop();
                    count++;
                }
                else
                {
                    st.Push(c);
                }
            }
            Console.WriteLine(count);
        }
    }
}
