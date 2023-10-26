using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool conditionOne = year % 4 == 0;
        bool conditionTwo = year % 100 == 0;
        bool conditionThree = year % 400 == 0;

        return conditionOne && (!conditionTwo || conditionThree);
    }
}

