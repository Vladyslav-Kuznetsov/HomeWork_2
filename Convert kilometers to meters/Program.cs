using System;


namespace Convert_kilometers_to_meters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Conversion type:\n\t1 - Kilometers to meters\n\t2 - Meters to kilometers\nEnter command:");
            if (byte.TryParse(Console.ReadLine(), out byte command) && (command == 1 || command == 2))
            {
                switch (command)
                {
                    case 1:
                        Console.Write("Enter kilometers:");
                        try
                        {
                            double kilometers = double.Parse(Console.ReadLine());
                            Console.WriteLine($"{kilometers} kilometers = {kilometers * 1000} meters");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Incorrect data");
                        }
                        break;
                    case 2:
                        Console.Write("Enter meters:");
                        try
                        {
                            double meters = double.Parse(Console.ReadLine());
                            Console.WriteLine($"{meters} meters = {meters / 1000} kilometers");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Incorrect data");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error!!!\nEntry can only be 1 or 2");
            }
            Console.ReadLine();
        }
    }
}
