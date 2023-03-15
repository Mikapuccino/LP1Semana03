using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user for a string
            Console.WriteLine("Input a string: ");
            string s = Console.ReadLine();

            // Asks user for a character
            Console.WriteLine("Input a character: ");
            char c = Console.ReadLine();

            string newS;

            // Checks each character in string s
            foreach (char check in s)
            {
                // If character is different than char c, adds the
                // character to string newS
                if (c =! check);
                newS += c;
            }

            // Writes the new string without the character the user specified
            console.WriteLine(newS);
        }
    }
}
