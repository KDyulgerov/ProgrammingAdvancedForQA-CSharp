using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{

    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        double inputAmount = 100;
        BankAccount bankAccount = new BankAccount(inputAmount);

        double expected = 100;

        double result = bankAccount.Balance;

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        double inputAmount = 0;
        BankAccount bankAccount = new BankAccount(inputAmount);

        double expected = 10.50;

        bankAccount.Deposit(10.50);
        double result = bankAccount.Balance;

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        double inputAmount = 100;
        BankAccount bankAccount = new BankAccount(inputAmount);

        Assert.That(() => bankAccount.Deposit(-10), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        double inputAmount = 100;
        BankAccount bankAccount = new BankAccount(inputAmount);

        double expected = 90;

        bankAccount.Withdraw(10);
        double result = bankAccount.Balance;

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        double inputAmount = 100;
        BankAccount bankAccount = new BankAccount(inputAmount);

        Assert.That(() => bankAccount.Withdraw(-10.50), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        double inputAmount = 100;
        BankAccount bankAccount = new BankAccount(inputAmount);

        Assert.That(() => bankAccount.Withdraw(200), Throws.ArgumentException);
    }
}
