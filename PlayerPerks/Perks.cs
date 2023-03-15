using System;

namespace PlayerPerks
{
    [Flags]
    public enum Perks
    {
        WaterBreathing = 1 << 0,
        Stealth        = 1 << 1,
        AutoHeal       = 1 << 2,
        DoubleJump     = 1 << 3
    };
}