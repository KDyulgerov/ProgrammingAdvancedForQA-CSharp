using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchPhoneNumbersTests
{
    [Test]
    public void Test_Match_ValidPhoneNumbers_ReturnsMatchedNumbers()
    {
        string phoneNumbers = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";
        string expected = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

        string result = MatchPhoneNumbers.Match(phoneNumbers);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_Match_NoValidPhoneNumbers_ReturnsEmptyString()
    {
        string phoneNumbers = "+359-2-124-56в78, 359 2 986 5432, +359-29-555-5555";
        string expected = string.Empty;

        string result = MatchPhoneNumbers.Match(phoneNumbers);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        string phoneNumbers = string.Empty;
        string expected = string.Empty;

        string result = MatchPhoneNumbers.Match(phoneNumbers);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_Match_MixedValidAndInvalidNumbers_ReturnsOnlyValidNumbers()
    {
        string phoneNumbers = "+359-2-124-5678, +359-2-124-56в78, 359 2 986 5432, +359-29-555-5555, +359 2 986 5432, +359-2-555-5555";
        string expected = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

        string result = MatchPhoneNumbers.Match(phoneNumbers);

        Assert.That(expected, Is.EqualTo(result));
    }
}
