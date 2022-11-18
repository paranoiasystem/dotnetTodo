using Core.Exceptions;

namespace Core.Entities;

public class Todo
{
    private String _id;
    private String _title;
    private String _description;
    private TodoStatus _status;
    
    public Todo(String id, String title, String description, TodoStatus status)
    {
        _id = id;
        _title = title;
        _description = description;
        _status = status;
    }
    
    public void MarkAsDone()
    {
        if (_status == TodoStatus.Done)
        {
            throw new TodoAlReadyDone(_id);
        }
        _status = TodoStatus.Done;
    }
    
    public void MarkAsInProgress()
    {
        if (_status == TodoStatus.InProgress)
        {
            throw new TodoAlReadyInProgress(_id);
        }
        _status = TodoStatus.InProgress;
    }
    
    public String Id()
    {
        return _id;
    }
    
    public String Title()
    {
        return _title;
    }
    
    public String Description()
    {
        return _description;
    }
    
    public TodoStatus Status()
    {
        return _status;
    }
}