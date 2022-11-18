using Core.Entities;

namespace Core.Interfaces.IRepository;

public interface ITodoRepository
{
    void Save(Todo todo);
    List<Todo> GetAll();
    void Update(Todo todo);
    List<Todo> getNewTodos();
}