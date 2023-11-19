using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();

        string result = Plants.GetFastestGrowing(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        string[] input = { "Rose" };

        StringBuilder expected = new StringBuilder();
        expected.Append($"Plants with 4 letters:{Environment.NewLine}Rose");

        string result = Plants.GetFastestGrowing(input);

        Assert.That(expected.ToString(), Is.EqualTo(result));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        string[] input = { "Rose", "lilium", "nacius" };

        StringBuilder expected = new StringBuilder();
        expected.Append($"Plants with 4 letters:{Environment.NewLine}Rose{Environment.NewLine}");
        expected.Append($"Plants with 6 letters:{Environment.NewLine}lilium{Environment.NewLine}nacius");

        string result = Plants.GetFastestGrowing(input);

        Assert.That(expected.ToString(), Is.EqualTo(result));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        string[] input = { "Rose", "liliuM", "naciuS", "Rose", "rose" };

        StringBuilder expected = new StringBuilder();
        expected.Append($"Plants with 4 letters:{Environment.NewLine}" +
            $"Rose{Environment.NewLine}" +
            $"Rose{Environment.NewLine}" +
            $"rose{Environment.NewLine}");
        expected.Append($"Plants with 6 letters:{Environment.NewLine}" +
            $"liliuM{Environment.NewLine}" +
            $"naciuS");

        string result = Plants.GetFastestGrowing(input);

        Assert.That(expected.ToString(), Is.EqualTo(result));
    }
}
