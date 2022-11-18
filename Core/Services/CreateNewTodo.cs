using Core.Entities;
using Core.Interfaces.IRepository;

namespace Core.Services;

public class CreateNewTodo
{
    
    private readonly ITodoRepository _todoRepository;
    
    public CreateNewTodo(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }
    
    public Todo Execute(String title, String description)
    {
        Todo todo = new Todo(
            Guid.NewGuid().ToString(),
            title,
            description,
            TodoStatus.New
        );
        _todoRepository.Save(todo);
        return todo;
    }
}