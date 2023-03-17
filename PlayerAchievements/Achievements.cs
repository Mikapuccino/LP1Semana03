using System;

namespace PlayerAchievements
{
    [Flags]
    public enum Achievements
    {
        DefeatOptionalBoss = 1 << 0, 
        FindHiddenLevel = 1 << 1, 
        FinishGame = 1 << 2
    };
}