using Core.Entities;
using Core.Interfaces.IRepository;
using Core.Services;
using Infrastructure.Repository;

namespace CoreTest.Services;

public class CreateNewTodoTest
{

    private ITodoRepository _todoRepository;

    [SetUp]
    public void Setup()
    {
        AppDbContext context = new AppDbContext();
        context.Database.EnsureCreated();
        _todoRepository = new TodoRepository(context);
    }
    
    [Test]
    public void CreateNewTodo()
    {
        CreateNewTodo createNewTodo = new CreateNewTodo(_todoRepository);
        Todo todo = createNewTodo.Execute("Test", "Test Description");
        Assert.NotNull(todo.Id);
        Assert.AreEqual("Test", todo.Title);
        Assert.AreEqual("Test Description", todo.Description);
        Assert.AreEqual(TodoStatus.New, todo.Status);
        
        List<Todo> todos = _todoRepository.getNewTodos();
        
        Assert.AreEqual(3, todos.Count);
    }
}