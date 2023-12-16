using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> firstDictInput = new ();
        Dictionary<string, int> secondDictInput = new ();

        Dictionary<string, int> expected = new ();

        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictInput, secondDictInput);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> firstDictInput = new();
        Dictionary<string, int> secondDictInput = new()
        {
            ["frist"] = 1,
        };

        Dictionary<string, int> expected = new();

        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictInput, secondDictInput);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> firstDictInput = new()
        {
            ["first"] = 1,
        };
        Dictionary<string, int> secondDictInput = new()
        {
            ["second"] = 2,
        };

        Dictionary<string, int> expected = new();

        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictInput, secondDictInput);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        Dictionary<string, int> firstDictInput = new()
        {
            ["first"] = 1,
            ["second"] = 2,
            ["third"] = 3,
        };
        Dictionary<string, int> secondDictInput = new()
        {
            ["first"] = 1,
            ["second"] = 2,
            ["3000"] = 3000,
        };

        Dictionary<string, int> expected = new()
        {
            ["first"] = 1,
            ["second"] = 2,
        };

        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictInput, secondDictInput);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> firstDictInput = new()
        {
            ["first"] = 1,
            ["second"] = 2,
            ["third"] = 3,
        };
        Dictionary<string, int> secondDictInput = new()
        {
            ["first"] = 10,
            ["second"] = 20,
            ["3000"] = 3000,
        };

        Dictionary<string, int> expected = new();

        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictInput, secondDictInput);

        Assert.That(result, Is.EqualTo(expected));
    }
}
