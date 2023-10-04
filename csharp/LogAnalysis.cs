using System;
using System.Linq;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string separator)
    {
        return str
            .Split(separator)
            .Last();
    }

    public static string SubstringBetween(this string str, string first, string last)
    {
        return str
            .Split(first)
            .Last()
            .Split(last)
            .First();
    }
    
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }

    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}
