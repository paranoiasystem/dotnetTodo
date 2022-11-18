using Core.Entities;
using Core.Exceptions;

namespace CoreTest;

public class UnitTestTodo
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestTodo()
    {
        Todo testTodo = new Todo("1", "Test Todo", "Test Description", TodoStatus.New);
        Assert.AreEqual("1", testTodo.Id());
        Assert.AreEqual("Test Todo", testTodo.Title());
        Assert.AreEqual("Test Description", testTodo.Description());
        Assert.AreEqual(TodoStatus.New, testTodo.Status());
    }
}