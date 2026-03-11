namespace ProductSales_
{
    struct Product
    {
        public string ProductID;
        public int TotalSales;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> productMap = new Dictionary<string, int>();

            Console.WriteLine("Enter product records (Press Enter twice to stop):");

            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;

                string[] parts = input.Split('-');
                string id = parts[0];
                int sales = int.Parse(parts[1]);

                if (!productMap.ContainsKey(id) || productMap[id] < sales)
                {
                    productMap[id] = sales;
                }
            }

            var sorted = productMap.OrderByDescending(x => x.Value);

            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Key}-{item.Value}");
            }
        }
    }
}
