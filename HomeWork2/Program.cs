using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length");
            bool l = int.TryParse(Console.ReadLine(), out int length);
            Console.WriteLine("Enter Width");
            bool w = int.TryParse(Console.ReadLine(), out int width);

            if (l && w)
            {
                for (int i = 1; i <= width; i++)
                {
                    for (int j = 1; j <= length; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Incorrect data");
            }

            Console.ReadLine();
        }
    }
}
