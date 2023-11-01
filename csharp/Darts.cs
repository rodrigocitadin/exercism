using System;

public static class Darts
{
    public static int Score(double x, double y) =>
        Hypot(x, y) switch 
        {
            > 10.0 => 0,
            > 5.0 => 1,
            > 1.0 => 5,
            _ => 10
        };

    private static double Hypot(double x, double y) => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
}

