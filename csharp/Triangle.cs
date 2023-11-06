using System;

public static class Triangle
{
    public static bool IsScalene(double x, double y, double z)
        => Inequality(x, y, z)
        && (x != y && x != z && y != z);

    public static bool IsIsosceles(double x, double y, double z)
        => Inequality(x, y, z)
        && (x == y || x == z || y == z);

    public static bool IsEquilateral(double x, double y, double z)
        => Inequality(x, y, z)
        && x == y
        && y == z;

    public static bool Inequality(double x, double y, double z)
        => x < y + z
        && y < x + z
        && z < x + y;
}

