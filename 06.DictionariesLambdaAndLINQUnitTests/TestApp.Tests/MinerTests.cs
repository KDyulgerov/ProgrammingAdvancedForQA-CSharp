using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();

        string result = Miner.Mine(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        string[] input = { "GoLd 100", "silver 200", "COPPER 50", "GOLD 50" };

        StringBuilder expected = new StringBuilder();
        expected.Append($"gold -> 150{Environment.NewLine}");
        expected.Append($"silver -> 200{Environment.NewLine}");
        expected.Append($"copper -> 50");

        string result = Miner.Mine(input);

        Assert.That(expected.ToString(), Is.EqualTo(result));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        string[] input = { "gold 100", "silver 200", "silver 50", "gold 0", "gold 3", "copper 0", "copper 50" };

        StringBuilder expected = new StringBuilder();
        expected.Append($"gold -> 103{Environment.NewLine}");
        expected.Append($"silver -> 250{Environment.NewLine}");
        expected.Append($"copper -> 50");

        string result = Miner.Mine(input);

        Assert.That(expected.ToString(), Is.EqualTo(result));
    }
}
