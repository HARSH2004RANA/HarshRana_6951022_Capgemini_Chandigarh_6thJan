namespace ReverseString
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);

            Console.WriteLine("Reversed String: " + new string(arr));
        }
    }
}
