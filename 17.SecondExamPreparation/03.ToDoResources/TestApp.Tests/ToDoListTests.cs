using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        string? title = "Example Title";
        DateTime dueTime = DateTime.Now;

        _toDoList.AddTask(title, dueTime);
        string result = _toDoList.DisplayTasks();

        Assert.That(result, Does.Contain("To-Do List:"));
        Assert.That(result, Does.Contain($"[ ] {title} - Due: "));
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        string? title = "Example Title";
        DateTime dueTime = DateTime.Now;

        _toDoList.AddTask(title, dueTime);
        _toDoList.CompleteTask(title);
        string result = _toDoList.DisplayTasks();

        Assert.That(result, Does.Contain("To-Do List:"));
        Assert.That(result, Does.Contain($"[✓] {title} - Due: "));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        string? title = "Example Title";
        DateTime dueTime = DateTime.Now;
        string titleNotFound = "alabala";

        _toDoList.AddTask(title, dueTime);

        Assert.That(() => _toDoList.CompleteTask(titleNotFound), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        string expected = "To-Do List:";

        string result = _toDoList.DisplayTasks();

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        string? title = "Example Title";
        DateTime dueTime = DateTime.Now;
        _toDoList.AddTask(title, dueTime);

        string? title2 = "Example Title 2.0";
        DateTime dueTime2 = DateTime.Now;
        _toDoList.AddTask(title2, dueTime2);

        string result = _toDoList.DisplayTasks();

        Assert.That(result, Does.Contain("To-Do List:"));
        Assert.That(result, Does.Contain($"[ ] {title} - Due: "));
        Assert.That(result, Does.Contain($"[ ] {title2} - Due: "));
    }
}
