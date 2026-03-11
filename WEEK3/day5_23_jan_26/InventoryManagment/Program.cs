namespace InventoryManagment
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Inventory inv = new Inventory();
            int choice;

            do
            {
                Console.WriteLine("\n===== Inventory Management System =====");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Show Books Cheaper Than Given Price");
                Console.WriteLine("3. Increase Price of All Books");
                Console.WriteLine("4. Remove Out-of-Stock Books");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        inv.AddBook();
                        break;

                    case 2:
                        Console.WriteLine("Enter target price:");
                        int target = int.Parse(Console.ReadLine());
                        inv.CheaperThen(target);
                        break;

                    case 3:
                        Console.WriteLine("Enter percentage to increase price:");
                        double percent = double.Parse(Console.ReadLine());
                        inv.IncreasePrice(percent);
                        Console.WriteLine("Prices updated successfully.");
                        break;

                    case 4:
                        inv.RemoveOutOfStockBooks();
                        break;

                    case 5:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }

            } while (choice != 5);

            Console.ReadLine();
        }
    }
}
