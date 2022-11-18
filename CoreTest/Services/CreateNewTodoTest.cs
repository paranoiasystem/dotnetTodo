using Core.Entities;
using Core.Services;
using Infrastructure.Repository.InMemory;

namespace CoreTest.Services;

public class CreateNewTodoTest
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public void CreateNewTodo()
    {
        CreateNewTodo createNewTodo = new CreateNewTodo(new TodoRepository());
        Todo todo = createNewTodo.Execute("Test", "Test Description");
        Assert.NotNull(todo.Id);
        Assert.AreEqual("Test", todo.Title);
        Assert.AreEqual("Test Description", todo.Description);
        Assert.AreEqual(TodoStatus.New, todo.Status);
    }
}