using Core.Exceptions;

namespace Core.Entities;
public class Todo
{
    public string Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public TodoStatus Status { get; private set; }
    
    public Todo(string id, string title, string description, TodoStatus status)
    {
        this.Id = id;
        Title = title;
        Description = description;
        Status = status;
    }
    
    public void MarkAsDone()
    {
        if (Status == TodoStatus.Done)
        {
            throw new TodoAlReadyDone(Id);
        }
        Status = TodoStatus.Done;
    }
    
    public void MarkAsInProgress()
    {
        if (Status == TodoStatus.InProgress)
        {
            throw new TodoAlReadyInProgress(Id);
        }
        Status = TodoStatus.InProgress;
    }
}