using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] numberSplit = phoneNumber.Split('-');
        bool IsNewYork = numberSplit[0].Equals("212");
        bool IsFake = numberSplit[1].Equals("555");

        return (IsNewYork, IsFake, numberSplit[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}

