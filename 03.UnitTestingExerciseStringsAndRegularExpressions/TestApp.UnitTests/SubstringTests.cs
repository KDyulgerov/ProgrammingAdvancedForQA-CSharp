using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown jumps over the lazy dog";

        string result = Substring.RemoveOccurrences(toRemove, input);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        string toRemove = "the";
        string input = "The quick brown  jumps over the lazy dog";
        string expected = "quick brown jumps over lazy dog";

        string result = Substring.RemoveOccurrences(toRemove, input);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        string toRemove = "dog";
        string input = "The quick brown DOG jumps over the lazy dog";
        string expected = "The quick brown jumps over the lazy";

        string result = Substring.RemoveOccurrences(toRemove, input);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        string toRemove = "dog";
        string input = "dogdog";
        string expected = string.Empty;

        string result = Substring.RemoveOccurrences(toRemove, input);

        Assert.That(expected, Is.EqualTo(result));
    }
}
