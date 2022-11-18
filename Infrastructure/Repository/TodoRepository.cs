using Core.Entities;
using Core.Interfaces.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class TodoRepository : ITodoRepository
{
    private DbSet<Todo> _todos;
    private AppDbContext _context;
    
    public TodoRepository(AppDbContext context)
    {
        _context = context;
        _todos = _context.Todos;
    }
    
    public void Save(Todo todo)
    {
        _todos.Add(todo);
        _context.SaveChanges();
    }

    public List<Todo> GetAll()
    {
        return _todos.ToList();
    }

    public void Update(Todo todo)
    {
        _todos.Update(todo);
    }

    public List<Todo> getNewTodos()
    {
        return _todos.Where(t => t.Status == TodoStatus.New).ToList();
    }
}