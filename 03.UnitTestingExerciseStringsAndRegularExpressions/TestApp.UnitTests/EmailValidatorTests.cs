using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    [TestCase("test@example.com")]
    [TestCase("example123@co.uk")]
    [TestCase("12342@alabala.domain")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        bool result = EmailValidator.IsValidEmail(email);

        Assert.That(result, Is.True);
    }

    [TestCase("invalid.com")]
    [TestCase("!#@$@abc.bg")]
    [TestCase("example@invalid")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        bool result = EmailValidator.IsValidEmail(email);
        
        Assert.That(result, Is.False);
    }
}
