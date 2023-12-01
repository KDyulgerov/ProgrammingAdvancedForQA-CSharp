using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PlanetTests
{
    [Test]
    public void Test_CalculateGravity_ReturnsCorrectCalculation()
    {
        Planet earth = new("Earth", 12742, 149600000, 1);
        double mass = 1000;
        double expectedGravity = mass * 6.67430e-11 / Math.Pow(earth.Diameter / 2, 2);

        double result = earth.CalculateGravity(mass);

        Assert.That (result, Is.EqualTo(expectedGravity));
    }

    [Test]
    public void Test_GetPlanetInfo_ReturnsCorrectInfo()
    {
        Planet earth = new("Earth", 12742, 149600000, 1);
        string expected = $"Planet: Earth{Environment.NewLine}" +
                          $"Diameter: 12742 km{Environment.NewLine}" +
                          $"Distance from the Sun: 149600000 km{Environment.NewLine}" +
                          $"Number of Moons: 1";

        string result = earth.GetPlanetInfo();

        Assert.That(result, Is.EqualTo(expected));
    }
}
