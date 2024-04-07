using System;

public class SpaceAge
{
    private const double EarthYearInSeconds = 31557600;
    private readonly int _seconds;
    
    public SpaceAge(int seconds)
    {
        _seconds = seconds;
    }

    public double OnEarth() => _seconds / EarthYearInSeconds;

    public double OnMercury() => OnEarth() / 0.2408467;

    public double OnVenus() => OnEarth() / 0.61519726;

    public double OnMars() => OnEarth() / 1.8808158;

    public double OnJupiter() => OnEarth() / 11.862615;

    public double OnSaturn() => OnEarth() / 29.447498;

    public double OnUranus() => OnEarth() / 84.016846;

    public double OnNeptune() => OnEarth() / 164.79132;
}