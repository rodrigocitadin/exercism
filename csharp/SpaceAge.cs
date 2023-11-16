using System;

public class SpaceAge
{
    public double age;

    private const double _earthYear = 31557600;
    private const double _mercury = 0.2408467;
    private const double _venus = 0.61519726;
    private const double _mars = 1.8808158;
    private const double _jupiter = 11.862615;
    private const double _saturn = 29.447498;
    private const double _uranus = 84.016846;
    private const double _neptune = 164.79132;

    public SpaceAge(int seconds) => age = seconds / _earthYear;

    public double OnEarth() => age;

    public double OnMercury() => age / _mercury;

    public double OnVenus() => age / _venus;

    public double OnMars() => age / _mars;

    public double OnJupiter() => age / _jupiter;

    public double OnSaturn() => age / _saturn;

    public double OnUranus() => age / _uranus;

    public double OnNeptune() => age / _neptune;
}

