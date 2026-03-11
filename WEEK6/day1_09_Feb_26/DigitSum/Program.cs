namespace DigitSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
            int sum = 0;
            while (num!=0)
            {
                int r = num % 10;
                num /= 10;
                sum += r;
            }
            Console.WriteLine(sum);
        }
    }
}
