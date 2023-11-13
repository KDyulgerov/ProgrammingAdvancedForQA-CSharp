using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        string input = string.Empty;

        List<string> result = MatchUrls.ExtractUrls(input);

        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        string input = "gpiapgjapdga;dgoa gpadjpdgjap";

        List<string> result = MatchUrls.ExtractUrls(input);

        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        string input = "afsfas https://www.softuni.bg faas";
        List<string> expected = new List<string> { "https://www.softuni.bg" };

        List<string> result = MatchUrls.ExtractUrls(input);

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        string input = "http://www.softuni.bg ala bala https://softuni.com as https://www.softuni.net";
        List<string> expected = new List<string> { "http://www.softuni.bg", "https://softuni.com", "https://www.softuni.net" };

        List<string> result = MatchUrls.ExtractUrls(input);

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        string input = "\"https://www.softuni.bg\" ala bala https://www.softuni.com as https://www.softuni.net";
        List<string> expected = new List<string> { "https://www.softuni.bg", "https://www.softuni.com", "https://www.softuni.net" };

        List<string> result = MatchUrls.ExtractUrls(input);

        CollectionAssert.AreEqual(expected, result);
    }
}
