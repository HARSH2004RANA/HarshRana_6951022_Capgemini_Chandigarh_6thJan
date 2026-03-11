using System.Text.Json;
using System;
namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student { Name = "Harsh", Age = 21 };
            string jsonSerial=JsonSerializer.Serialize(s);
            Console.WriteLine(jsonSerial);
        }
    }
}
