namespace InsertInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string s=Console.ReadLine();
            Console.WriteLine("Enter character");
            char ch=char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Position:");
            int pos=int.Parse(Console.ReadLine());
            string ans = s.Insert(pos,ch.ToString());
            Console.WriteLine(ans);

            
        }
    }
}
