using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("ab", 2, "aBaB")]
    [TestCase("a", 1, "a")]
    [TestCase("$", 10, "$$$$$$$$$$")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        string input = string.Empty;
        int repetitionFctr = 1;

        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFctr), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        string input = "ab";
        int repetitionFctr = -1;

        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFctr), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        string input = "ab";
        int repetitionFctr = 0;

        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFctr), Throws.ArgumentException);
    }
}
