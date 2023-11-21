using System;
using System.Linq;
using System.Collections.Generic;

public static class Languages
{
    public static List<string> NewList() => new List<string>();

    public static List<string> GetExistingLanguages() => new List<string> {"C#", "Clojure", "Elm"};

    public static List<string> AddLanguage(List<string> languages, string language) => languages.Append<string>(language).ToList();

    public static int CountLanguages(List<string> languages) => languages.Count;

    public static bool HasLanguage(List<string> languages, string language) => languages.Contains(language);

    public static List<string> ReverseList(List<string> languages) => languages.Reverse<string>().ToList();

    public static bool IsExciting(List<string> languages)
    {
        bool count = CountLanguages(languages) switch
        {
            0 => false,
            > 3 => false,
            _ => true
        };

        bool index = languages.IndexOf("C#") switch
        {
            0 => true,
            1 => true,
            _ => false
        };

        return index && count;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language) => languages.Where(l => l != language).ToList();

    public static bool IsUnique(List<string> languages) => languages.Count == languages.Distinct().Count();
}

