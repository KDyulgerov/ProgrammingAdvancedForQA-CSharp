using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchNamesTests
{
    [Test]
    public void Test_Match_ValidNames_ReturnsMatchedNames()
    {
        string names = "John Smith and Alice Johnson";
        string expected = "John Smith Alice Johnson";

        string result = MatchNames.Match(names);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_Match_NoValidNames_ReturnsEmptyString()
    {
        string names = "jJohn sSmith and aAlice jJohnson";
        string expected = string.Empty;

        string result = MatchNames.Match(names);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        string names = string.Empty;
        string expected = string.Empty;

        string result = MatchNames.Match(names);

        Assert.That(expected, Is.EqualTo(result));
    }
}
