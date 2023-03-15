using System;

namespace PlayerPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables used to count characters in the string
            int wCount = 0;
            int aCount = 0;
            int sCount = 0;
            int dCount = 0;
            
            // For each character in the string, it checks if it is 'w', 'a',
            // 's' or 'd', and increments appropriate variable
            foreach (char c in args[0])
            {                
                if (c == 'w')
                {
                    wCount += 1;
                }

                else if (c == 'a')
                {
                    aCount += 1;
                }

                else if (c == 's')
                {
                    sCount += 1;
                }

                else if (c == 'd')
                {
                    dCount += 1;
                }

                else
                {
                    Console.WriteLine("Unknown perk!");
                    Environment.Exit(1);
                }
            }

            // Initialize userPerks with every possible perk
            Perks userPerks = Perks.WaterBreathing | Perks.AutoHeal | 
            Perks.Stealth | Perks.DoubleJump;
            
            // Removes perks based on how many specific characters
            // the user input
            if ((wCount % 2) == 0)
            {
                userPerks &= ~Perks.WaterBreathing;
            }

            if ((aCount % 2) == 0)
            {
                userPerks &= ~Perks.AutoHeal;
            }

            if ((sCount % 2) == 0)
            {
                userPerks &= ~Perks.Stealth;
            }

            if ((dCount % 2) == 0)
            {
                userPerks &= ~Perks.DoubleJump;
            }

            // Writes active perks on console
            Console.WriteLine(userPerks);
            
            // If DoubleJump and Stealth perks are active,
            // writes message on console
            if (((userPerks & Perks.DoubleJump) == Perks.DoubleJump) & 
            ((userPerks & Perks.Stealth) == Perks.Stealth))
            {
                Console.WriteLine("Silent jumper!");
            }

            // If AutoHeal perk is not active, writes message on console
            if ((userPerks & Perks.AutoHeal) == Perks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");
            }
        }
    }
}
