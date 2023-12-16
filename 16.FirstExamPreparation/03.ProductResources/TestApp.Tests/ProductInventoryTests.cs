using NUnit.Framework;
using System;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        string nameInput = "SomeName";
        double priceInput = 2.20001;
        int quantityInput = 1;
        string expected = $"Product Inventory:{Environment.NewLine}" +
            $"SomeName - Price: $2.20 - Quantity: 1";

        _inventory.AddProduct(nameInput, priceInput, quantityInput);
        string result = _inventory.DisplayInventory();

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        string expected = "Product Inventory:";

        string result = _inventory.DisplayInventory();

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        string nameInput = "SomeName2";
        double priceInput = 2.2;
        int quantityInput = 10000;

        string nameInput2 = "abc";
        double priceInput2 = 1;
        int quantityInput2 = 1;

        string expected = $"Product Inventory:{Environment.NewLine}" +
            $"SomeName2 - Price: $2.20 - Quantity: 10000{Environment.NewLine}" +
            $"abc - Price: $1.00 - Quantity: 1";

        _inventory.AddProduct(nameInput, priceInput, quantityInput);
        _inventory.AddProduct(nameInput2, priceInput2, quantityInput2);
        string result = _inventory.DisplayInventory();

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        double expected = 0.0;

        double result = _inventory.CalculateTotalValue();

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        string nameInput = "SomeName";
        double priceInput = 2.0;
        int quantityInput = 1;
        double expected = 2.0;

        _inventory.AddProduct(nameInput, priceInput, quantityInput);
        double result = _inventory.CalculateTotalValue();

        Assert.That(result, Is.EqualTo(expected));
    }
}
