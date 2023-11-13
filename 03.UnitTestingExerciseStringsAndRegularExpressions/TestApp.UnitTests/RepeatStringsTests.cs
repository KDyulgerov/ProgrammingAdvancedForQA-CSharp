using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class RepeatStringsTests
{
    [Test]
    public void Test_Repeat_EmptyInput_ReturnsEmptyString()
    {
        string[] input = Array.Empty<string>();

        string result = RepeatStrings.Repeat(input);

        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Repeat_SingleInputString_ReturnsRepeatedString()
    {
        string[] input = { "Abc" };
        string expected = "AbcAbcAbc";

        string  result = RepeatStrings.Repeat(input);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
    {
        string[] input = { "Abc", "123", "0" };
        string expected = "AbcAbcAbc1231231230";

        string result = RepeatStrings.Repeat(input);

        Assert.That(expected, Is.EqualTo(result));
    }
}
