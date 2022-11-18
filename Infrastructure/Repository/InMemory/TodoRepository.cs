using Core.Entities;
using Core.Interfaces.IRepository;

namespace Infrastructure.Repository.InMemory;

public class TodoRepository : ITodoRepository
{
    private static readonly List<Todo> Todos = new List<Todo>();

    public void Save(Todo todo)
    {
        Todos.Add(todo);
    }

    public List<Todo> GetAll()
    {
        return Todos;
    }

    public void Update(Todo todo)
    {
        Todo? result = Todos.FirstOrDefault(x => x.Id == todo.Id);
        if(result != null)
        {
            result = todo;
        }
        else
        {
            // TODO: refactor this
            throw new Exception("Todo not found");
        }
        
    }
}