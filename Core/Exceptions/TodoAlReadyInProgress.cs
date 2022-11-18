namespace Core.Exceptions;

public class TodoAlReadyInProgress : Exception
{
    public TodoAlReadyInProgress(string id) : base(String.Format("Todo with id {0} is already in progress", id)) {}
}