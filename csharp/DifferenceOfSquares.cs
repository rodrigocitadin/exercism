using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int n)
    {
        int total = 0;

        // for (; n > 0; n--) total += n;

        while (n > 0)
        {
            total += n;
            n--;
        }

        return total * total;
    }

    public static int CalculateSumOfSquares(int n)
    {
        int total = 0;

        // for (; n > 0; n--) total += n * n;

        while (n > 0)
        {
            total += n * n;
            n--;
        }

        return total;
    }

    public static int CalculateDifferenceOfSquares(int n) =>
        CalculateSquareOfSum(n) - CalculateSumOfSquares(n);
}

