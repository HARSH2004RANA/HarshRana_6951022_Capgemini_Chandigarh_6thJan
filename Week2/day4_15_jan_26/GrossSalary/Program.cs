namespace GrossSalary
{
    internal class Program
    {
        static int CalculateGross(int basicPay, int days)
        {
            if (basicPay < 0) return -1;
            if (basicPay > 10000) return -2;
            if (days > 31) return -3;

            int da = (basicPay * 75) / 100;
            int hra = (basicPay * 50) / 100;

            return basicPay + da + hra;
        }

        static public void Main()
        {
            int basicPay = 6000;
            int days = 30;

            int output1 = CalculateGross(basicPay, days);
            Console.WriteLine(output1);
        }
    }
}
