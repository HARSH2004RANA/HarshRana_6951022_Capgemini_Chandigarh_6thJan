using System.Text.RegularExpressions;

namespace LocationUpdater
{
    internal class Program
    {
        public static void UpdateLocation(string invoiceNumber, string newLocation)
        {
            Match match = Regex.Match(invoiceNumber, @"CAP-([A-Z]+)-(\d+)");

            if (match.Success)
            {
                string numericPart = match.Groups[2].Value;

                string updatedInvoice = "CAP-" + newLocation + "-" + numericPart;

                Console.WriteLine("Updated Invoice: " + updatedInvoice);
            }
            else
            {
                Console.WriteLine("Invalid Invoice Format");
            }
        }

        static void Main(string[] args)
        {
            UpdateLocation("CAP-HYD-1234", "BAN");
            Console.ReadLine();
        }
    }
}
