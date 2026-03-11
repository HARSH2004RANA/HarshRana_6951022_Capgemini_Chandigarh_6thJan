using System.Xml.Linq;

namespace E_CommerceProductCatalog
{
    class Product
    {
    private string name;
    private double price;
    private int stock;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Stock
    {
        get { return stock; }
        set { stock = value; }
    }

    public virtual string Category()
    {
        return "General";
    }

    public virtual void ShowDetails()
    {
        Console.WriteLine($"{Name} | ₹{Price} | Stock: {Stock} | Category: {Category()}");
    }
}

class Electronics : Product
{
    public int Warranty { get; set; }

    public override string Category()
    {
        return "Electronics";
    }
}

class Clothing : Product
{
    public string Size { get; set; }

    public override string Category()
    {
        return "Clothing";
    }
}

class Books : Product
{
    public string Author { get; set; }

    public override string Category()
    {
        return "Books";
    }
}

class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
}

class Cart
{
    public List<Product> Items { get; set; } = new List<Product>();

    public void AddToCart(Product p)
    {
        Items.Add(p);
    }

    public double GetTotal()
    {
        double total = 0;
        foreach (var item in Items)
            total += item.Price;
        return total;
    }

    public void ShowCart()
    {
        Console.WriteLine("\n--- Cart Items ---");
        foreach (var item in Items)
            Console.WriteLine($"{item.Name} - ₹{item.Price}");
        Console.WriteLine("Total: ₹" + GetTotal());
    }
}

class Order
{
    public Customer Customer { get; set; }
    public Cart Cart { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;

    public void ShowOrder()
    {
        Console.WriteLine("\nOrder Details:");
        Console.WriteLine($"Customer: {Customer.Name}");
        Console.WriteLine($"Order Date: {OrderDate}");
        Cart.ShowCart();
    }
}

    class Program
    {
        static List<Product> products = new List<Product>();
        static List<Order> orders = new List<Order>();
        static Customer customer = new Customer { CustomerId = 1, Name = "Harsh Rana" };

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n====== E-Commerce Product Catalog ======");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View All Products");
                Console.WriteLine("3. Filter Products by Category");
                Console.WriteLine("4. Add Product to Cart & Place Order");
                Console.WriteLine("5. View Orders");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddProduct(); break;
                    case 2: ViewProducts(); break;
                    case 3: FilterByCategory(); break;
                    case 4: PlaceOrder(); break;
                    case 5: ViewOrders(); break;
                    case 6: return;
                    default: Console.WriteLine("Invalid choice!"); break;
                }
            }
        }

        static void AddProduct()
        {
            Console.WriteLine("Select Product Category:");
            Console.WriteLine("1. Electronics");
            Console.WriteLine("2. Clothing");
            Console.WriteLine("3. Books");
            int type = int.Parse(Console.ReadLine());

            Product p = null;

            if (type == 1) p = new Electronics();
            else if (type == 2) p = new Clothing();
            else if (type == 3) p = new Books();
            else
            {
                Console.WriteLine("Invalid Category!");
                return;
            }

            Console.Write("Enter Product Name: ");
            p.Name = Console.ReadLine();

            Console.Write("Enter Price: ");
            p.Price = double.Parse(Console.ReadLine());

            Console.Write("Enter Stock Quantity: ");
            p.Stock = int.Parse(Console.ReadLine());

            products.Add(p);
            Console.WriteLine("Product Added Successfully!");
        }

        static void ViewProducts()
        {
            Console.WriteLine("\n--- Product List ---");
            foreach (var p in products)
                p.ShowDetails();
        }

        static void FilterByCategory()
        {
            Console.WriteLine("Enter Category (Electronics / Clothing / Books): ");
            string category = Console.ReadLine();

            Console.WriteLine($"\n--- {category} Products ---");
            foreach (var p in products)
            {
                if (p.Category().Equals(category, StringComparison.OrdinalIgnoreCase))
                    p.ShowDetails();
            }
        }

        static void PlaceOrder()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            Cart cart = new Cart();

            while (true)
            {
                Console.WriteLine("\nSelect a product to add to cart:");
                for (int i = 0; i < products.Count; i++)
                    Console.WriteLine($"{i + 1}. {products[i].Name} - ₹{products[i].Price} - Stock: {products[i].Stock}");

                Console.WriteLine("0. Checkout");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                    break;

                Product selected = products[choice - 1];

                if (selected.Stock <= 0)
                {
                    Console.WriteLine("Product out of stock!");
                    continue;
                }

                selected.Stock--; // Manage Inventory
                cart.AddToCart(selected);
                Console.WriteLine("Product added to cart!");
            }

            if (cart.Items.Count > 0)
            {
                Order order = new Order
                {
                    Customer = customer,
                    Cart = cart
                };

                orders.Add(order);
                Console.WriteLine("Order Placed Successfully!");
                order.ShowOrder();
            }
            else
            {
                Console.WriteLine("Cart is empty. No order placed.");
            }
        }

        static void ViewOrders()
        {
            Console.WriteLine("\n--- All Orders ---");
            foreach (var o in orders)
                o.ShowOrder();

        }
    }
}
