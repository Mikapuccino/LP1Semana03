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
            
            // For each character in the string, it checks if it is "w", "a",
            // "s" or "d", and increments appropriate variable
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
            }

            Console.WriteLine(wCount);
            Console.WriteLine(aCount);
            Console.WriteLine(sCount);
            Console.WriteLine(dCount);
        }
    }
}
