using Core.Entities;
using Core.Exceptions;

namespace CoreTest;

public class TodoExceptionTest
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public void TestTodoExceptionAlReadyDone()
    {
        Todo testTodo = new Todo("1", "Test Todo", "Test Description", TodoStatus.Done);
        Assert.Throws<TodoAlReadyDone>(() => testTodo.MarkAsDone());
    }
    
    [Test]
    public void TestTodoExceptionAlReadyInProgress()
    {
        Todo testTodo = new Todo("1", "Test Todo", "Test Description", TodoStatus.InProgress);
        Assert.Throws<TodoAlReadyInProgress>(() => testTodo.MarkAsInProgress());
    }
}