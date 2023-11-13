using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        string[] input = Array.Empty<string>();
        string expected = string.Empty;

        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        string[] input = { "abc" };
        string expected = "abc";

        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        string[] input = { "abc", "123", "0" };
        string expected = "0123abc";

        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        string[]? input = null;
        string expected = string.Empty;

        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        string[]? input = { "a", " ", "b", "  ", "c" };
        string expected = "c  b a";

        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        string[]? input = { "a", " ", "b", "  ", "c", "one", "1234567890problem" };
        string expected = "1234567890problemonec  b a";

        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(expected, Is.EqualTo(result));
    }
}
