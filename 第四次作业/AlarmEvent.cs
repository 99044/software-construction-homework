namespace ConsoleApp4;

public class AlarmEvent : EventArgs
{
    public string Message { get; }

    public AlarmEvent(string message)
    {
        Message = message;
    }
}