using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) =>
        shirtNum switch
        {
            1 => "goalie",
            2 => "left back",
            <= 4 => "center back",
            5 => "right back",
            <= 8 => "midfielder",
            9 => "left wing",
            10 => "striker",
            11 => "right wing",
            _ => throw new ArgumentOutOfRangeException()
        };

    public static string AnalyzeOffField(object report) =>
        report switch
        {
            int x => $"There are {x} supporters at the match.",
            string x => x,
            Foul x => x.GetDescription(),
            Injury x => $"Oh no! {x.GetDescription()} Medics are on the field.",
            Incident x => x.GetDescription(),
            Manager x => x.Club is null ? x.Name : $"{x.Name} ({x.Club})",
            _ => throw new ArgumentException()
        };
}

public class Manager
{
    public string Name { get; }
    public string? Club { get; }

    public Manager(string name, string? club)
    {
        this.Name = name;
        this.Club = club;
    }
}

public class Incident
{
    public virtual string GetDescription() => "An incident happened.";
}

public class Foul : Incident
{
    public override string GetDescription() => "The referee deemed a foul.";
}

public class Injury : Incident
{
    private readonly int player;

    public Injury(int player)
    {
        this.player = player;
    }

    public override string GetDescription() => $"Player {player} is injured.";
}

