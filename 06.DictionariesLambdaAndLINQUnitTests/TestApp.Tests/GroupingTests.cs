using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class GroupingTests
{
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        List<int> input = new();

        string result = Grouping.GroupNumbers(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new List<int> { 1, 2, 3, 24 };

        StringBuilder expected = new StringBuilder();
        expected.Append($"Odd numbers: 1, 3{Environment.NewLine}");
        expected.Append($"Even numbers: 2, 24");

        string result = Grouping.GroupNumbers(input);

        CollectionAssert.AreEqual(expected.ToString(), result);
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new List<int> { 4, 2, 6 };

        StringBuilder expected = new StringBuilder();
        expected.Append($"Even numbers: 4, 2, 6");

        string result = Grouping.GroupNumbers(input);

        CollectionAssert.AreEqual(expected.ToString(), result);

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new List<int> { 1, 3, 13 };

        StringBuilder expected = new StringBuilder();
        expected.Append($"Odd numbers: 1, 3, 13");

        string result = Grouping.GroupNumbers(input);

        CollectionAssert.AreEqual(expected.ToString(), result);

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new List<int> { -1, -3, -13 };

        StringBuilder expected = new StringBuilder();
        expected.Append($"Odd numbers: -1, -3, -13");

        string result = Grouping.GroupNumbers(input);

        CollectionAssert.AreEqual(expected.ToString(), result);
    }
    [Test]
    public void Test_GroupNumbers_WithMixedNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new List<int> { -1, 3, -3, -13, 23 };

        StringBuilder expected = new StringBuilder();
        expected.Append($"Odd numbers: -1, 3, -3, -13, 23");

        string result = Grouping.GroupNumbers(input);

        CollectionAssert.AreEqual(expected.ToString(), result);
    }
    [Test]
    public void Test_GroupNumbers_WithSingleNumber_ShouldReturnGroupedString()
    {
        List<int> input = new List<int> { 0 };

        StringBuilder expected = new StringBuilder();
        expected.Append($"Even numbers: 0");

        string result = Grouping.GroupNumbers(input);

        CollectionAssert.AreEqual(expected.ToString(), result);
    }

    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString2()
    {
        List<int> input = new List<int>();

        string result = Grouping.GroupNumbers(input);

        Assert.That(result, Is.Empty);
    }
}
