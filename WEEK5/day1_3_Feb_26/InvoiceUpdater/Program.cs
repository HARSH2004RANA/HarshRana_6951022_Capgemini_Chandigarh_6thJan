using System.Text.RegularExpressions;

namespace InvoiceUpdater
{
    internal class Program
    {
        public static void UpdateInvoice(string currentInvoice, int increment)
        {
            Match match = Regex.Match(currentInvoice, @"CAP-(\d+)");

            if (match.Success)
            {
                int number = int.Parse(match.Groups[1].Value);
                int newNumber = number + increment;

                string updatedInvoice = "CAP-" + newNumber;

                Console.WriteLine("Updated Invoice: " + updatedInvoice);
            }
            else
            {
                Console.WriteLine("Invalid Invoice Format");
            }
        }

        static void Main(string[] args)
        {
            UpdateInvoice("CAP-123", 7);
            Console.ReadLine();
        }
    }
}
