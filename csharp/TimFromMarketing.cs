using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        department ??= "owner";

        // if (id == null)
        // {
        //    return $"{name} - {department?.ToUpper()}";
        // }
        // 
        // return $"[{id}] - {name} - {department?.ToUpper()}";
        
        return id == null
            ? $"{name} - {department?.ToUpper()}"
            : $"[{id}] - {name} - {department?.ToUpper()}";
    }
}

