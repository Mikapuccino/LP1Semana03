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

            // After adding achievements to all players, cycle repeats
            // for each player
            for (int player = 0; player < n; player++)
            {
                // If player has no achievements
                if ((int) PlayerAchievements[player] == 0)
                {
                    Console.WriteLine($"Player {player + 1} " +
                    "has no achievements");
                }
                
                // If player has only 1 achievement
                else if ((int) PlayerAchievements[player] == 1 | 
                (int) PlayerAchievements[player] == 2 |
                (int) PlayerAchievements[player] == 4)
                {
                    Console.WriteLine($"Player {player + 1} has the " +
                    $"{PlayerAchievements[player]} achievement");
                }
                
                // If player has multiple achievements
                else
                {
                    Console.WriteLine($"Player {player + 1} has the " +
                    $"{PlayerAchievements[player]} achievements");
                }

                // If player has all achievements
                if ((int) PlayerAchievements[player] == 7)
                {
                    Console.WriteLine("Completionist!");
                }
            }
        }
    }
}
