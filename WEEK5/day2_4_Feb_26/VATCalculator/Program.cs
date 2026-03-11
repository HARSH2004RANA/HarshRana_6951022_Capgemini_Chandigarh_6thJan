namespace VATCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Product Type (M/V/C/D): ");
            char product = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.Write("Enter Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            double vatPercentage = 0;

            switch (product)
            {
                case 'M':
                    vatPercentage = 5;
                    break;
                case 'V':
                    vatPercentage = 12;
                    break;
                case 'C':
                    vatPercentage = 6.25;
                    break;
                case 'D':
                    vatPercentage = 6;
                    break;
                default:
                    Console.WriteLine("Invalid Product Type");
                    return;
            }

            double vatAmount = (vatPercentage / 100) * amount;

            Console.WriteLine("VAT % = " + vatPercentage);
            Console.WriteLine("VAT Amount = " + vatAmount);
        }
    }
}
