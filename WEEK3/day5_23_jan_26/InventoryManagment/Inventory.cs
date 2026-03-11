using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace InventoryManagment
{
    internal class Inventory
    {
        Dictionary<int, (string name, double price, int count)> Inv = new Dictionary<int, (string, double, int)>();
        int items;
        public Inventory()
        {
            this.items = 0;
        }
        public void AddBook()
        {
            Console.WriteLine("Item name :");
            string name=Console.ReadLine();
            Console.WriteLine("Item price :");
            double price=double.Parse(Console.ReadLine());
            Console.WriteLine("Item stock :");
            int count=int.Parse(Console.ReadLine());
            this.Inv.Add(this.items++,(name, price, count));
        }
        public void CheaperThen(int target)
        {
            var books=from book in this.Inv
                      where book.Value.price <=target
                      select book;
            foreach (var book in books)
            {
                Console.WriteLine($"book Id : {book.Key}, Book Name : {book.Value.name} , Price : {book.Value.price}");
            }
        }
        public void IncreasePrice(double percent)
        {
            foreach (var book in Inv.Keys.ToList())
            {
                var item = Inv[book];

                double increase = item.price * percent / 100;
                double newPrice = item.price + increase;

                Inv[book] = (item.name, newPrice, item.count);
            }
        }
        public void RemoveOutOfStockBooks()
        {
            List<int> removeKeys = new List<int>();

            foreach (var book in Inv)
            {
                if (book.Value.count == 0)
                {
                    removeKeys.Add(book.Key);
                }
            }

            foreach (int key in removeKeys)
            {
                Inv.Remove(key);
            }

            Console.WriteLine("All out-of-stock books have been removed.");
        }


    }
}
