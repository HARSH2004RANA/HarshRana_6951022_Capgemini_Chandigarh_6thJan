using System.Collections.Specialized;

namespace NumberOfCouples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = [2, 2, 4, 4,0];
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if ((arr[i] + arr[i - 1]) % n == 0)
                {
                    count++;
                }
            }
           
            Console.WriteLine(count);
        }
    }
}
