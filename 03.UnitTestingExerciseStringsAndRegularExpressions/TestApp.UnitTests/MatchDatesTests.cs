using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        string input = "31-Dec-2022";
        string expected = "Day: 31, Month: Dec, Year: 2022";

        string result = MatchDates.Match(input);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        string input = "Invalid date format";
        string expected = string.Empty;

        string result = MatchDates.Match(input);

        Assert.That(expected, Is.EqualTo(result));

    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        string input = "31-Dec-2022, 20-Dec-2022, 31 - Dec - 2022";
        string expected = "Day: 31, Month: Dec, Year: 2022";

        string result = MatchDates.Match(input);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        string input = string.Empty;
        string expected = string.Empty;

        string result = MatchDates.Match(input);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        string? input = null;

        Assert.That(() => MatchDates.Match(input), Throws.ArgumentException);
    }
}
