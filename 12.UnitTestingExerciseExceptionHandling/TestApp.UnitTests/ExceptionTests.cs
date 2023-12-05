using NuGet.Frameworks;
using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        string input = "HellO";
        string expected = "OlleH";

        string result = this._exceptions.ArgumentNullReverse(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        string? input = null;

        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        decimal input = 100;
        decimal discount = 10;
        decimal expected = 90;

        decimal result = this._exceptions.ArgumentCalculateDiscount(input, discount);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        decimal input = 100;
        decimal discount = -10;

        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(input, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        decimal input = 100.0m;
        decimal discount = 110.0m;

        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(input, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        int[] input = { 1, 2, 3 };
        int index = 1;
        int expected = 2;

        int result = this._exceptions.IndexOutOfRangeGetElement(input, index);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        int[] input = { 1, 2, 3 };
        int index = -1;

        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(input, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        int[] input = { 10, 20, 30, 40, 50 };
        int index = input.Length;

        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(input, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        int[] input = { 10, 20, 30, 40, 50 };
        int index = input.Length + 1;

        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(input, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        bool input = true;
        string expected = "User logged in.";

        string result = this._exceptions.InvalidOperationPerformSecureOperation(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        bool input = false;

        Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(input), Throws.InvalidOperationException);
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        string input = "123";
        int expected = 123;

        int result = this._exceptions.FormatExceptionParseInt(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        string input = "123abc";

        Assert.That(() => this._exceptions.FormatExceptionParseInt(input), Throws.InstanceOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        Dictionary<string, int> DictionaryInput = new()
        {
            ["first"] = 1,
            ["second"] = 2,
            ["third"] = 3,
        };
        int expected = 2;

        int result = this._exceptions.KeyNotFoundFindValueByKey(DictionaryInput, "second");

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        Dictionary<string, int> DictionaryInput = new()
        {
            ["first"] = 1,
            ["second"] = 2,
            ["third"] = 3,
        };

        Assert.That(() => this._exceptions.KeyNotFoundFindValueByKey(DictionaryInput, "invalidKey"), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        int num1 = 100;
        int num2 = 1;
        int expected = 101;

        int result = this._exceptions.OverflowAddNumbers(num1, num2);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;

        Assert.That(() => this._exceptions.OverflowAddNumbers(num1, num2), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        int num1 = int.MinValue;
        int num2 = int.MinValue;

        Assert.That(() => this._exceptions.OverflowAddNumbers(num1, num2), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        int num1 = 10;
        int num2 = 2;
        int expected = 5;

        int result = this._exceptions.DivideByZeroDivideNumbers(num1, num2);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        int num1 = 10;
        int num2 = 0;

        Assert.That(() => this._exceptions.DivideByZeroDivideNumbers(num1, num2), Throws.InstanceOf<DivideByZeroException>());
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        int[] input = { 1, 2, 3 };
        int index = 2;
        int expected = 6;

        int result = this._exceptions.SumCollectionElements(input, index);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        int[]? input = null;
        int index = 3;

        Assert.That(() => this._exceptions.SumCollectionElements(input, index), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        int[] input = { 1, 2, 3 };
        int index = 3;

        Assert.That(() => this._exceptions.SumCollectionElements(input, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        Dictionary<string, string> input = new Dictionary<string, string>()
        {
            ["first"] = "1",
            ["second"] = "2",
            ["third"] = "3",
        };
        string key = "second";
        int expected = 2;

        int result = this._exceptions.GetElementAsNumber(input, key);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        Dictionary<string, string> input = new Dictionary<string, string>()
        {
            ["first"] = "1",
            ["second"] = "2",
            ["third"] = "3",
        };
        string key = "alabala";

        Assert.That(() => this._exceptions.GetElementAsNumber(input, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        Dictionary<string, string> input = new Dictionary<string, string>()
        {
            ["first"] = "1",
            ["second"] = "abc",
            ["third"] = "3",
        };
        string key = "second";

        Assert.That(() => this._exceptions.GetElementAsNumber(input, key), Throws.InstanceOf<FormatException>());
    }
}
