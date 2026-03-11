namespace SalaryStory
{
    internal class Program
    {
        static int CalculateSavings(int input1, int input2)
        {
            if (input1 > 9000) return -1;
            if (input1 < 0) return -3;
            if (input2 < 0) return -4;

            int salary = input1;
            if (input2 == 31) salary += 500;

            int food = (salary * 50) / 100;
            int travel = (salary * 20) / 100;

            return salary - (food + travel);
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
