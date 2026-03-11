namespace Savings
{
    internal class Program
    {
        static int CalculateSavings(int input1, int input2)
        {
            if (input1 > 9000) return -1;
            if (input1 < 0) return -2;
            if (input2 < 0) return -4;

            int extra = (input2 == 31) ? 500 : 0;
            int totalSalary = input1 + extra;

            int food = (totalSalary * 50) / 100;
            int travel = (totalSalary * 20) / 100;

            int savings = totalSalary - (food + travel);

            return savings;
        }

        static public void Main()
        {
            int input1 = 7000;
            int input2 = 31;

            int output1 = CalculateSavings(input1, input2);

            Console.WriteLine(output1);
        }
    }
}
