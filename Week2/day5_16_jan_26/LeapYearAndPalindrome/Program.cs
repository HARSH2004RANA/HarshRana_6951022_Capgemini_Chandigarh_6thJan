namespace LeapYear
{
    internal class Program
    {
        static int IsLeapYear(int year)
        {
            if (year < 0) return -1;
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) return 1;
            return 0;
        }

        

        static public void Main()
        {
            int year = 2024;
            int leapResult = IsLeapYear(year);
            Console.WriteLine(leapResult);

            
        }
    }
}
