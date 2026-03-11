namespace Delegates
{
    
    internal class Program
    {
        public delegate void Math(int x, int y);
        static void Main(string[] args)
        {
            MultiClass obj=new MultiClass();
            Math m = new Math(obj.add);
            m += obj.sub;
            m += obj.mul;
            m += obj.div;
            m(100, 50);
            Console.WriteLine();
            m -= obj.sub;
            m(20, 5);
            m += obj.add;
            m(34, 6);
        }
    }
}
