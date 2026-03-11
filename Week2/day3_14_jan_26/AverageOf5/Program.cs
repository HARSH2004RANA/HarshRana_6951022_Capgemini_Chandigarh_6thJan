namespace AverageOfMutliple5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Limit = int.Parse(Console.ReadLine());
            int Sum = 0;
            int count = 0;

            if (Limit < 0)
            {
                Console.WriteLine(-1);
                return;
            }

            for (int i = 1; i <= Limit; i++)
            {
                if (i % 5 == 0)
                {
                    Sum += i;     
                    count++;     
                }
            }

            if (count == 0)
            {
                Console.WriteLine(0); 
            }
            else
            {
                float average = (float)Sum / count;
                Console.WriteLine(average);
            }
        }
    }
}
