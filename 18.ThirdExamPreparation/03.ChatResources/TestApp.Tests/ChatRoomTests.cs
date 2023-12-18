using System;

using NUnit.Framework;

using TestApp.Chat;

namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;
    
    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }
    
    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        string sender = "John";
        string message = "Welcome";

        _chatRoom.SendMessage(sender, message);
        string result = _chatRoom.DisplayChat();

        Assert.That(result, Does.Contain("Chat Room Messages:"));
        Assert.That(result, Does.Contain("John: Welcome - Sent at "));
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        string result = _chatRoom.DisplayChat();

        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        string sender = "John";
        string message = "Welcome";
        _chatRoom.SendMessage(sender, message);

        string sender2 = "Mike";
        string message2 = "Welcome to you!";
        _chatRoom.SendMessage(sender2, message2);

        string result = _chatRoom.DisplayChat();

        Assert.That(result, Does.Contain("Chat Room Messages:"));
        Assert.That(result, Does.Contain("John: Welcome - Sent at "));
        Assert.That(result, Does.Contain("Mike: Welcome to you! - Sent at "));
    }
}
