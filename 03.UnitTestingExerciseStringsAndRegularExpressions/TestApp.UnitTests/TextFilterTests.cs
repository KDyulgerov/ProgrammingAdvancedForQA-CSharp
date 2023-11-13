using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        string[] bannedWords = { "ban" };
        string inputText = "Original Text";
        string expected = "Original Text";

        string result = TextFilter.Filter(bannedWords, inputText);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        string[] bannedWords = { "ban" };
        string inputText = "ban";
        string expected = "***";

        string result = TextFilter.Filter(bannedWords, inputText);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        string[] bannedWords = Array.Empty<string>();
        string inputText = "ban";
        string expected = "ban";

        string result = TextFilter.Filter(bannedWords, inputText);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        string[] bannedWords = { "ban ala" };
        string inputText = "ban ala";
        string expected = "*******";

        string result = TextFilter.Filter(bannedWords, inputText);

        Assert.That(expected, Is.EqualTo(result));
    }
}
