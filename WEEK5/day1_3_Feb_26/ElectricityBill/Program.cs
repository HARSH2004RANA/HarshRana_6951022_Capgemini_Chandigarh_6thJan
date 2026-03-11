using System.Text.RegularExpressions;

namespace ElectricityBill
{
    internal class Program
    {
        public static void CalculateBill(string input1, string input2, int ratePerUnit)
        {
            // Extract numeric values
            string num1 = Regex.Match(input1, @"\d+").Value;
            string num2 = Regex.Match(input2, @"\d+").Value;

            int reading1 = int.Parse(num1);
            int reading2 = int.Parse(num2);

            int difference = Math.Abs(reading2 - reading1);
            int billAmount = difference * ratePerUnit;

            Console.WriteLine("Electricity Bill Amount: " + billAmount);
        }

        static void Main(string[] args)
        {
            CalculateBill("AAAAA12345", "AAAAA23456", 4);
            Console.ReadLine();
        }
    }
}
