using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        var inputDictionary = new Dictionary<string, int>()
        {
            ["Ivan"] = 2,
            ["John"] = 4,
            ["Steve"] = 5,
            ["Alice"] = 3,
            ["Daisy Ivanova"] = 6,

        };
        string expected = $"Daisy Ivanova with average grade 6.00{Environment.NewLine}" +
            $"Steve with average grade 5.00{Environment.NewLine}" +
            $"John with average grade 4.00";

        string result = Grades.GetBestStudents(inputDictionary);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        var inputDictionary = new Dictionary<string, int>() { };

        string expected = string.Empty;

        string result = Grades.GetBestStudents(inputDictionary);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        var inputDictionary = new Dictionary<string, int>()
        {
            ["John"] = 4,
            ["Steve"] = 5,
        };
        string expected = $"Steve with average grade 5.00{Environment.NewLine}" +
            $"John with average grade 4.00";

        string result = Grades.GetBestStudents(inputDictionary);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        var inputDictionary = new Dictionary<string, int>()
        {
            ["Angel"] = 5,
            ["Aivan"] = 5,
            ["Artur"] = 5,
            ["Asen"] = 5,
            ["Asan"] = 5,
            ["Albert"] = 5,
        };
        string expected = $"Aivan with average grade 5.00{Environment.NewLine}" +
            $"Albert with average grade 5.00{Environment.NewLine}" +
            $"Angel with average grade 5.00";

        string result = Grades.GetBestStudents(inputDictionary);

        Assert.That(result, Is.EqualTo(expected));
    }
}
