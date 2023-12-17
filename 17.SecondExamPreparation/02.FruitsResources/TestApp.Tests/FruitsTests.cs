using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        Dictionary<string, int> inputDictionary = new Dictionary<string, int>()
        {
            ["banana"] = 1,
            ["apple"] = 3,
        };
        string fruitName = "banana";
        int expected = 1;

        int result = Fruits.GetFruitQuantity(inputDictionary, fruitName);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        Dictionary<string, int> inputDictionary = new Dictionary<string, int>()
        {
            ["banana"] = 1,
            ["apple"] = 3,
        };
        string fruitName = "kiwi";
        int expected = 0;

        int result = Fruits.GetFruitQuantity(inputDictionary, fruitName);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        Dictionary<string, int> inputDictionary = new Dictionary<string, int>() { };
        string fruitName = "kiwi";
        int expected = 0;

        int result = Fruits.GetFruitQuantity(inputDictionary, fruitName);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        Dictionary<string, int> inputDictionary = null!;
        string fruitName = "kiwi";
        int expected = 0;

        int result = Fruits.GetFruitQuantity(inputDictionary, fruitName);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        Dictionary<string, int> inputDictionary = new Dictionary<string, int>()
        {
            ["banana"] = 1,
            ["apple"] = 3,
        };
        string fruitName = null!;
        int expected = 0;

        int result = Fruits.GetFruitQuantity(inputDictionary, fruitName);

        Assert.That(result, Is.EqualTo(expected));
    }
}
