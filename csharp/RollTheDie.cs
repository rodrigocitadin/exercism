using System;

public class Player
{
    private readonly Random Rand = new();

    public int RollDie() => Rand.Next(1, 18);

    public double GenerateSpellStrength() => Rand.NextDouble() * 100;
}
