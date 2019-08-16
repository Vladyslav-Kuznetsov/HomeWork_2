using System;

namespace Alphabet_search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter letter:");

            if (char.TryParse(Console.ReadLine(), out char letter) && char.IsLetter(letter) && char.IsLower(letter))
            {
                Console.WriteLine($"Number in alphabet: {(int)letter - (int)'a' + 1}"); // countdown starts at 1
                Console.WriteLine("Change case? (Yes/No)");
                string yesOrNot = Console.ReadLine();
                Console.WriteLine(yesOrNot.ToLower() == "yes" ? char.ToUpper(letter) : letter);
            }
            else if (char.IsUpper(letter))
            {
                Console.WriteLine($"Number in alphabet: {(int)letter - (int)'A' + 1}"); // countdown starts at 1
                Console.WriteLine("Change case? (Yes/No)");
                string yesOrNot = Console.ReadLine();
                Console.WriteLine(yesOrNot.ToLower() == "yes" ? char.ToLower(letter) : letter);
            }
            else
            {
                Console.WriteLine("You can specify only one letter");
            }


            Console.ReadLine();
            
        }
    }
}
