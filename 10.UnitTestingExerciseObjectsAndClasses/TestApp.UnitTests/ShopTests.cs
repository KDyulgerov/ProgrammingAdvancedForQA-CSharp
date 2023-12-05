﻿using NUnit.Framework;

using System;

using TestApp.Store;

namespace TestApp.UnitTests;

public class ShopTests
{
    private Shop _shop;

    [SetUp]
    public void SetUp()
    {
        this._shop = new();
    }

    [Test]
    public void Test_AddAndGetBoxes_ReturnsSortedBoxes()
    {
        string[] products = { "12345 Widget 5 10.00", "54321 Gadget 3 15.00", "98765 Gizmo 2 8.00" };
        string expected = $"" +
            $"12345{Environment.NewLine}-- Widget - $10.00: 5{Environment.NewLine}-- $50.00{Environment.NewLine}" +
            $"54321{Environment.NewLine}-- Gadget - $15.00: 3{Environment.NewLine}-- $45.00{Environment.NewLine}" +
            $"98765{Environment.NewLine}-- Gizmo - $8.00: 2{Environment.NewLine}-- $16.00";

        string result = this._shop.AddAndGetBoxes(products);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetBoxes_ReturnsEmptyString_WhenNoProductsGiven()
    {
        string[] products = { };
        string expected = string.Empty;

        string result = this._shop.AddAndGetBoxes(products);

        Assert.That(result, Is.EqualTo(expected));
    }
}