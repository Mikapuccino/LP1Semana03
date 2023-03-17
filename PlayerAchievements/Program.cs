using System;

namespace PlayerAchievements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user to input number of players, stored in n
            Console.WriteLine("How many players?:");
            int n = int.Parse(Console.ReadLine());

            // Array with n size, going to hold achievements of each player
            Achievements [] PlayerAchievements = new Achievements[n];

            // Repeats cycle for each player
            for (int player = 0; player < n; player++)
            {
                // Repeats cycle for each achievement
                for (int achievement = 1; achievement <= 3; achievement++)
                {
                    // Achievement must equal 4 to get the last achievement
                    if (achievement == 3)
                    {
                        achievement = 4;
                    }
                    // Stores current achievement for later use
                    Achievements currentAchievement = (Achievements)achievement;
                    
                    Console.WriteLine($"Does player {player + 1} have the " +
                    $"{currentAchievement} achievement? Y or N: ");

                    string answer = Console.ReadLine();

                    // If user inputs "Y" or "y",
                    // adds achievement to that player
                    if (answer == "Y" || answer == "y")
                    {
                        PlayerAchievements[player] ^= currentAchievement;
                    }
                }
            }
        }
    }
}
