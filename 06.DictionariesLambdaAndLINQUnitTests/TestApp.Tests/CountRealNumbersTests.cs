using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        int[] input = Array.Empty<int>();

        string result = CountRealNumbers.Count(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        int[] input = { 1 };

        string result = CountRealNumbers.Count(input);

        StringBuilder expected = new();
        expected.Append($"1 -> 1");

        Assert.That(expected.ToString(), Is.EqualTo(result));

    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        int[] input = { 1, 2, 3, 1, 200 };

        string result = CountRealNumbers.Count(input);

        StringBuilder expected = new();
        expected.Append($"1 -> 2{Environment.NewLine}");
        expected.Append($"2 -> 1{Environment.NewLine}");
        expected.Append($"3 -> 1{Environment.NewLine}");
        expected.Append($"200 -> 1");

        Assert.That(expected.ToString(), Is.EqualTo(result));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        int[] input = { -1, -2, -30, -1 };

        string result = CountRealNumbers.Count(input);

        StringBuilder expected = new();
        expected.Append($"-30 -> 1{Environment.NewLine}");
        expected.Append($"-2 -> 1{Environment.NewLine}");
        expected.Append($"-1 -> 2");

        Assert.That(expected.ToString(), Is.EqualTo(result));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        int[] input = { 0 };

        string result = CountRealNumbers.Count(input);

        StringBuilder expected = new();
        expected.Append("0 -> 1");

        Assert.That(expected.ToString(), Is.EqualTo(result));
    }
    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString2()
    {
        int[] input = { 11, 11, 11 };

        string result = CountRealNumbers.Count(input);

        StringBuilder expected = new();
        expected.Append($"11 -> 3");

        Assert.That(expected.ToString(), Is.EqualTo(result));

    }
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString2()
    {
        int[] input = { -1, -2, -30, -1, 2 };

        string result = CountRealNumbers.Count(input);

        StringBuilder expected = new();
        expected.Append($"-30 -> 1{Environment.NewLine}");
        expected.Append($"-2 -> 1{Environment.NewLine}");
        expected.Append($"-1 -> 2{Environment.NewLine}");
        expected.Append($"2 -> 1");

        Assert.That(expected.ToString(), Is.EqualTo(result));
    }
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString2()
    {
        int[] input = { };

        string result = CountRealNumbers.Count(input);

        Assert.That(result, Is.Empty);
    }
    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString2()
    {
        int[] input = { 0, 0, 0, 0 };

        string result = CountRealNumbers.Count(input);

        StringBuilder expected = new();
        expected.Append("0 -> 4");

        Assert.That(expected.ToString(), Is.EqualTo(result));
    }
}