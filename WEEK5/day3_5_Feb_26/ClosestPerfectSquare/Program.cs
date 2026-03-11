namespace ClosestPerfectSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());

            int root = (int)Math.Sqrt(number);
            int lowerSquare = root * root;
            int upperSquare = (root + 1) * (root + 1);

            int closest = (number - lowerSquare <= upperSquare - number)
                          ? lowerSquare
                          : upperSquare;

            Console.WriteLine("Closest Perfect Square: " + closest);
        }
    }
}
