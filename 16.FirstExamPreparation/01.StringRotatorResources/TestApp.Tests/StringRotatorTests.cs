using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        string input = string.Empty;
        int position = 2;

        string result = StringRotator.RotateRight(input, position);

        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        string input = "abc";
        int position = 0;
        string expected = "abc";

        string result = StringRotator.RotateRight(input, position);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        string input = "abc";
        int position = 1;
        string expected = "cab";

        string result = StringRotator.RotateRight(input, position);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        string input = "abc";
        int position = -1;
        string expected = "cab";

        string result = StringRotator.RotateRight(input, position);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        string input = "abc";
        int position = 6;
        string expected = "abc";

        string result = StringRotator.RotateRight(input, position);

        Assert.That(result, Is.EqualTo(expected));
    }
}
