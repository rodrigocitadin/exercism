using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        string[] line = logLine.Split(':');
        return line[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        string[] line = logLine.Split('[', ']');
        return line[1].ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string log = LogLevel(logLine);

        return $"{message} ({log})";
    }
}

