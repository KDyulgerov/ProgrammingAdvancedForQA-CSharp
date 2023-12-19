using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        int input = 0;

        Dictionary<int, int> expected = new Dictionary<int, int>();

        Dictionary<int, int> result = NumberFrequency.CountDigits(input);

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        int input = 8;

        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            [8] = 1,
        };

        Dictionary<int, int> result = NumberFrequency.CountDigits(input);

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        int input = 822333;

        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            [8] = 1,
            [2] = 2,
            [3] = 3,
        };

        Dictionary<int, int> result = NumberFrequency.CountDigits(input);

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        int input = -822333;

        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            [8] = 1,
            [2] = 2,
            [3] = 3,
        };

        Dictionary<int, int> result = NumberFrequency.CountDigits(input);

        CollectionAssert.AreEqual(expected, result);
    }
}
