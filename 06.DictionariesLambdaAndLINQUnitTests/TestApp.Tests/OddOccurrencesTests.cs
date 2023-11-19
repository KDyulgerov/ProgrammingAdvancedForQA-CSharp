using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();
        
        string result = OddOccurrences.FindOdd(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        string[] input = { "alabala", "alabala" };

        string result = OddOccurrences.FindOdd(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        string[] input = { "alabala", "alabala", "alabala" };

        string expected = "alabala";

        string result = OddOccurrences.FindOdd(input);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        string[] input = { "alabala", "abc", "alabala", "alabala" };

        string expected = "alabala abc";

        string result = OddOccurrences.FindOdd(input);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        string[] input = { "alaBala", "aBc", "alaBAla", "alabaLA", "A", "a", "A" };

        string expected = "alabala abc a";

        string result = OddOccurrences.FindOdd(input);

        Assert.That(expected, Is.EqualTo(result));
    }
}
