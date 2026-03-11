namespace DivisibleCouples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N (array size): ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter array elements separated by space:");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int count = 0;

            for (int i = 0; i < N - 1; i++)
            {
                int sum = arr[i] + arr[i + 1];

                if (sum % N == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Total Couples Divisible by N: " + count);
        }
    }
}
