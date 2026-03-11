namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine($"Add : {cal.Add(5,3)}");
            Console.WriteLine($"Subtract : {cal.Subtract(5, 3)}");
            Console.WriteLine($"Multiply : {cal.Multiply(5, 3)}");
            Console.WriteLine($"Divide : {cal.Divide(5, 3)}");
        }
    }
}
