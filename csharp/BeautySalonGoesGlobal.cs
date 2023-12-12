using System;
using System.Globalization;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime(); 

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        var dateTime = DateTime.Parse(appointmentDateDescription);
        var timeZoneInfo = GetTimeZoneInfo(location);

        return TimeZoneInfo.ConvertTimeToUtc(dateTime, timeZoneInfo);
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel) => alertLevel switch
    {
        AlertLevel.Early => appointment.AddDays(-1),
        AlertLevel.Standard => appointment.AddHours(-1.75),
        AlertLevel.Late => appointment.AddMinutes(-30),
        _ => throw new Exception()
    };

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        var timeZoneInfo = GetTimeZoneInfo(location);
        var sevenDaysEarlier = dt.AddDays(-7);

        return (timeZoneInfo.IsDaylightSavingTime(dt) != timeZoneInfo.IsDaylightSavingTime(sevenDaysEarlier));
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        var cultureInfo = LocationCultureInfo(location);
        var isSuccess = DateTime.TryParse(dtStr, cultureInfo, DateTimeStyles.None, out var dateTime);

        return isSuccess ? dateTime : new(1, 1, 1);
    }
	
    private static TimeZoneInfo GetTimeZoneInfo(Location location)
    {
        var timeZoneID = TimeZoneID(location);

        return TimeZoneInfo.FindSystemTimeZoneById(timeZoneID);
    }

    private static CultureInfo LocationCultureInfo(Location location)
    {
        var culture = location switch
        {
            Location.NewYork => "en-US",
            Location.London => "en-GB",
            Location.Paris => "fr-FR",
            _ => throw new ArgumentOutOfRangeException(),
        };

        return CultureInfo.GetCultureInfo(culture);
    }

    private static string TimeZoneID(Location location) => location switch
    {
        Location.NewYork => IsWindows() ? "Eastern Standard Time" : "America/New_York",
        Location.London => IsWindows() ? "GMT Standard Time" : "Europe/London",
        Location.Paris => IsWindows() ? "W. Europe Standard Time" : "Europe/Paris",
        _ => throw new ArgumentOutOfRangeException(),
    };
	
	private static bool IsWindows() => OperatingSystem.IsWindows();
}

