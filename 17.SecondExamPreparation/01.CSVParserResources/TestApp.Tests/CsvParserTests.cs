using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        string input = null!;
        string[] expected = Array.Empty<string>();

        string[] result = CsvParser.ParseCsv(input);

        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        string input = "sigleElement";
        string[] expected = { "sigleElement" };

        string[] result = CsvParser.ParseCsv(input);

        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        string input = "alabala,one,two,three,1";
        string[] expected = { "alabala", "one", "two", "three", "1" };

        string[] result = CsvParser.ParseCsv(input);

        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        string input = " ala bala,    one,    two,  three,1 ";
        string[] expected = { "ala bala", "one", "two", "three", "1" };

        string[] result = CsvParser.ParseCsv(input);

        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray2()
    {
        string input = "         ";
        string[] expected = { "" };

        string[] result = CsvParser.ParseCsv(input);

        CollectionAssert.AreEqual(result, expected);
    }
}
