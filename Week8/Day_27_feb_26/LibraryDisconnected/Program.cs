
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace LibraryDisconnected
{
    class Program
    {
        static string conStr =
        "Server=LAPTOP-NSP89M6A\\sqlexpress;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True";

        static DataSet ds = new DataSet();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n===== LIBRARY MANAGEMENT =====");
                Console.WriteLine("1. Load Books");
                Console.WriteLine("2. Insert Book");
                Console.WriteLine("3. Update Book");
                Console.WriteLine("4. Delete Book");
                Console.WriteLine("5. Exit");

                switch (Console.ReadLine())
                {
                    case "1": LoadBooks(); break;
                    case "2": InsertBook(); break;
                    case "3": UpdateBook(); break;
                    case "4": DeleteBook(); break;
                    case "5": return;
                }
            }
        }

        static void LoadBooks()
        {
            using SqlConnection con = new SqlConnection(conStr);

            SqlDataAdapter da = new SqlDataAdapter("sp_GetBooks", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            ds.Clear();
            da.Fill(ds, "Books");

            DisplayBooks();
        }

        static void DisplayBooks()
        {
            Console.WriteLine("\n--- BOOK LIST (FROM MEMORY) ---");

            foreach (DataRow row in ds.Tables["Books"].Rows)
            {
                Console.WriteLine($"{row["BookId"]} | {row["Title"]} | {row["AuthorName"]} | {row["PublishedYear"]}");
            }
        }

        static void InsertBook()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("AuthorId: ");
            int authorId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            using SqlConnection con = new SqlConnection(conStr);

            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("sp_InsertBook", con);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;

            da.InsertCommand.Parameters.AddWithValue("@Title", title);
            da.InsertCommand.Parameters.AddWithValue("@AuthorId", authorId);
            da.InsertCommand.Parameters.AddWithValue("@PublishedYear", year);

            con.Open();
            da.InsertCommand.ExecuteNonQuery();

            Console.WriteLine("✅ Book Inserted");
        }

        static void UpdateBook()
        {
            Console.Write("BookId: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("New Title: ");
            string title = Console.ReadLine();

            Console.Write("AuthorId: ");
            int authorId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            using SqlConnection con = new SqlConnection(conStr);

            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = new SqlCommand("sp_UpdateBook", con);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;

            da.UpdateCommand.Parameters.AddWithValue("@BookId", id);
            da.UpdateCommand.Parameters.AddWithValue("@Title", title);
            da.UpdateCommand.Parameters.AddWithValue("@AuthorId", authorId);
            da.UpdateCommand.Parameters.AddWithValue("@PublishedYear", year);

            con.Open();
            da.UpdateCommand.ExecuteNonQuery();

            Console.WriteLine("✅ Book Updated");
        }

        static void DeleteBook()
        {
            Console.Write("BookId: ");
            int id = Convert.ToInt32(Console.ReadLine());

            using SqlConnection con = new SqlConnection(conStr);

            SqlDataAdapter da = new SqlDataAdapter();
            da.DeleteCommand = new SqlCommand("sp_DeleteBook", con);
            da.DeleteCommand.CommandType = CommandType.StoredProcedure;

            da.DeleteCommand.Parameters.AddWithValue("@BookId", id);

            con.Open();
            da.DeleteCommand.ExecuteNonQuery();

            Console.WriteLine("✅ Book Deleted");
        }
    }
}
