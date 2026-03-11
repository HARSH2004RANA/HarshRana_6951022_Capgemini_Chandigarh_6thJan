using System;

namespace BinaryToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int output = BinaryToDecimal(input1);
            Console.WriteLine(output);
        }

        static int BinaryToDecimal(int binary)
        {
            if (binary > 11111)
                return -2;

            int temp = binary;
            int baseValue = 1;
            int decimalValue = 0;

            while (temp > 0)
            {
                int lastDigit = temp % 10;

                if (lastDigit != 0 && lastDigit != 1)
                    return -1;

                decimalValue += lastDigit * baseValue;
                baseValue *= 2;
                temp /= 10;
            }

            return decimalValue;
        }
    }
}
