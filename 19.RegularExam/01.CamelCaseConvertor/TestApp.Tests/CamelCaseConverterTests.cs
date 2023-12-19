using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        string input = "";
        string expected = string.Empty;

        string result = CamelCaseConverter.ConvertToCamelCase(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        string input = "single";
        string expected = "single";

        string result = CamelCaseConverter.ConvertToCamelCase(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        string input = "multiple words input";
        string expected = "multipleWordsInput";

        string result = CamelCaseConverter.ConvertToCamelCase(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        string input = "MultiPle woRds MIXED case inPuT";
        string expected = "multipleWordsMixedCaseInput";

        string result = CamelCaseConverter.ConvertToCamelCase(input);

        Assert.That(result, Is.EqualTo(expected));
    }
}
