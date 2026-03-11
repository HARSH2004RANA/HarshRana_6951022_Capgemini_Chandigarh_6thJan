namespace LibrarySystem
{
    public interface IBook
    {
        int Id { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        string Category { get; set; }
        int Price { get; set; }
    }

    public interface ILibrarySystem
    {
        void AddBook(IBook book, int quantity);
        void RemoveBook(IBook book, int quantity);
        int CalculateTotal();
        List<(string, int)> CategoryTotalPrice();
        List<(string, int, int)> BooksInfo();
        List<(string, string, int)> CategoryAndAuthorWithCount();
    }

    public class Book : IBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
    }

    public class LibrarySystem : ILibrarySystem
    {
        private Dictionary<IBook, int> _books = new Dictionary<IBook, int>();

        public void AddBook(IBook book, int quantity)
        {
            var existing = _books.Keys.FirstOrDefault(b => b.Id == book.Id);

            if (existing != null)
            {
                _books[existing] += quantity;
            }
            else
            {
                _books.Add(book, quantity);
            }
        }

        public void RemoveBook(IBook book, int quantity)
        {
            var existing = _books.Keys.FirstOrDefault(b => b.Id == book.Id);

            if (existing != null)
            {
                _books[existing] -= quantity;

                if (_books[existing] <= 0)
                {
                    _books.Remove(existing);
                }
            }
        }

        public int CalculateTotal()
        {
            return _books.Sum(x => x.Key.Price * x.Value);
        }

        public List<(string, int)> CategoryTotalPrice()
        {
            return _books
                .GroupBy(x => x.Key.Category)
                .Select(g => (
                    g.Key,
                    g.Sum(x => x.Key.Price * x.Value)
                ))
                .ToList();
        }

        public List<(string, int, int)> BooksInfo()
        {
            return _books
                .Select(x => (
                    x.Key.Title,
                    x.Value,
                    x.Key.Price
                ))
                .ToList();
        }

        public List<(string, string, int)> CategoryAndAuthorWithCount()
        {
            return _books
                .GroupBy(x => new { x.Key.Category, x.Key.Author })
                .Select(g => (
                    g.Key.Category,
                    g.Key.Author,
                    g.Sum(x => x.Value)
                ))
                .ToList();
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            LibrarySystem librarySystem = new LibrarySystem();

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < n; i++)
            {
                var a = Console.ReadLine().Trim().Split(" ");

                IBook e = new Book();
                e.Id = Convert.ToInt32(a[0]);
                e.Title = a[1];
                e.Author = a[2];
                e.Category = a[3];
                e.Price = Convert.ToInt32(a[4]);

                librarySystem.AddBook(e, Convert.ToInt32(a[5]));
            }

            Console.WriteLine("Book Info:");
            var booksInfo = librarySystem.BooksInfo();

            foreach (var (title, quantity, price) in booksInfo.OrderBy(a => a.Item1))
            {
                Console.WriteLine($"Book Name:{title}, Quantity:{quantity}, Price:{price}");
            }

            Console.WriteLine("Category Total Price:");
            var categoryTotalPrice = librarySystem.CategoryTotalPrice();

            foreach (var (category, totalPrice) in categoryTotalPrice.OrderBy(a => a.Item1))
            {
                Console.WriteLine($"Category:{category}, Total Price:{totalPrice}");
            }

            Console.WriteLine("Category And Author With Count:");
            var categoryAndAuthorWithCount = librarySystem.CategoryAndAuthorWithCount();

            foreach (var (category, author, count) in categoryAndAuthorWithCount.OrderBy(a => a.Item1))
            {
                Console.WriteLine($"Category:{category}, Author:{author}, Count:{count}");
            }

            int total = librarySystem.CalculateTotal();
            Console.WriteLine($"Total Price: {total}");
        }
    }
}
