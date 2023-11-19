using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        List<string> input = new();

        string result = CountCharacters.Count(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        List<string> input = new() { "", "" };

        string result = CountCharacters.Count(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        List<string> input = new() { "g" };

        string expected = "g -> 1";

        string result = CountCharacters.Count(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        List<string> input = new() { "Gt1!" };

        StringBuilder expected = new();
        expected.Append($"G -> 1{Environment.NewLine}");
        expected.Append($"t -> 1{Environment.NewLine}");
        expected.Append($"1 -> 1{Environment.NewLine}");
        expected.Append("! -> 1");
        
        string result = CountCharacters.Count(input);

        Assert.That(result, Is.EqualTo(expected.ToString()));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        List<string> input = new() { "!#@$_" };

        StringBuilder expected = new();
        expected.Append($"! -> 1{Environment.NewLine}");
        expected.Append($"# -> 1{Environment.NewLine}");
        expected.Append($"@ -> 1{Environment.NewLine}");
        expected.Append($"$ -> 1{Environment.NewLine}");
        expected.Append("_ -> 1");

        string result = CountCharacters.Count(input);

        Assert.That(result, Is.EqualTo(expected.ToString()));
    }
    [Test]
    public void Test_Count_WithMultipleLetterCharacters_ShouldReturnCountString()
    {
        List<string> input = new() { "test" };

        StringBuilder expected = new();
        expected.Append($"t -> 2{Environment.NewLine}");
        expected.Append($"e -> 1{Environment.NewLine}");
        expected.Append("s -> 1");

        string result = CountCharacters.Count(input);

        Assert.That(result, Is.EqualTo(expected.ToString()));
    }
   
    [Test]
    public void Test_Count_WithWhiteSpace_ShouldReturnCountString()
    {
        List<string> input = new() { "test test" };

        StringBuilder expected = new();
        expected.Append($"t -> 4{Environment.NewLine}");
        expected.Append($"e -> 2{Environment.NewLine}");
        expected.Append($"s -> 2{Environment.NewLine}");
        expected.Append("  -> 1");

        string result = CountCharacters.Count(input);

        Assert.That(result, Is.EqualTo(expected.ToString()));
    }
    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString2()
    {
        List<string> input = new() { "GG" };

        string expected = "G -> 2";

        string result = CountCharacters.Count(input);

        Assert.That(result, Is.EqualTo(expected));
    }
}
