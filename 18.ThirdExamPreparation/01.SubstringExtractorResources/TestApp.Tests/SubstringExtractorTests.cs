using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        string input = "aaa bbb ccc";
        string startPoint = "aaa";
        string endPoint = "c";

        string expected = " bbb ";

        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startPoint, endPoint);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        string input = "aaa bbb ccc";
        string startPoint = "!@#";
        string endPoint = "c";

        string expected = "Substring not found";

        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startPoint, endPoint);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        string input = "aaa bbb ccc";
        string startPoint = "a";
        string endPoint = "123";

        string expected = "Substring not found";

        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startPoint, endPoint);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        string input = "aaa bbb ccc";
        string startPoint = "!@#";
        string endPoint = "123";

        string expected = "Substring not found";

        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startPoint, endPoint);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        string input = string.Empty;
        string startPoint = "!@#";
        string endPoint = "123";

        string expected = "Substring not found";

        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startPoint, endPoint);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        string input = "123456";
        string startPoint = "123";
        string endPoint = "345";

        string expected = "Substring not found";

        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startPoint, endPoint);

        Assert.That(result, Is.EqualTo(expected));
    }
}
