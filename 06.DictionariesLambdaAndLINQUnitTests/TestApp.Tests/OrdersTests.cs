using System;
using System.Text;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();

        string result = Orders.Order(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        string[] input = { "apple 2.000000 3", "banana 3.00 2", "kiwi 3 2", "apple 2.000000 1", "apple 1 1" };

        StringBuilder expected = new StringBuilder();
        expected.Append($"apple -> 5.00{Environment.NewLine}");
        expected.Append($"banana -> 6.00{Environment.NewLine}");
        expected.Append($"kiwi -> 6.00");

        string result = Orders.Order(input);

        Assert.That(expected.ToString(), Is.EqualTo(result));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        string[] input = { "apple 2.99999999999 3", "banana 3.0 2", "kiwi 3 2" };

        StringBuilder expected = new StringBuilder();
        expected.Append($"apple -> 9.00{Environment.NewLine}");
        expected.Append($"banana -> 6.00{Environment.NewLine}");
        expected.Append($"kiwi -> 6.00");

        string result = Orders.Order(input);

        Assert.That(expected.ToString(), Is.EqualTo(result));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        string[] input = { "apple 2.99999999999 3.0", "banana 3 2.000000001", "kiwi 3 1.99999999999999" };

        StringBuilder expected = new StringBuilder();
        expected.Append($"apple -> 9.00{Environment.NewLine}");
        expected.Append($"banana -> 6.00{Environment.NewLine}");
        expected.Append($"kiwi -> 6.00");

        string result = Orders.Order(input);

        Assert.That(expected.ToString(), Is.EqualTo(result));
    }
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString1()
    {
        string[] input = { };

        string result = Orders.Order(input);

        Assert.That(result, Is.Empty);
    }
}
