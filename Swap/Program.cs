using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            bool aIsInt = int.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("Enter second number");
            bool bIsInt = int.TryParse(Console.ReadLine(), out int b);
            if (aIsInt && bIsInt)
            {
                Console.WriteLine($"a = {a}, b = {b}");
                a += b;
                b = a - b;
                a -= b;
                Console.WriteLine($"a = {a}, b = {b}");
            }
            else
            {
                Console.WriteLine("Incorrect data");
            }

            Console.ReadLine();
        }
    }
}
