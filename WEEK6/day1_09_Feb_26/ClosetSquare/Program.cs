namespace ClosetSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
            int lower=(int)Math.Sqrt(n);
            int upper = (int)Math.Pow((lower + 1), 2);
            lower= (int)Math.Pow(lower,2);
            if (n - lower > upper - n)
            {
                Console.WriteLine(upper);
            }
            else
            {
                Console.WriteLine(lower);
            }
        }
    }
}
