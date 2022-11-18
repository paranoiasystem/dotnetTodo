namespace Core.Exceptions;

public class TodoAlReadyDone : Exception
{
    public TodoAlReadyDone(string id) : base(String.Format("Todo with id {0} is already done", id)) {}
}