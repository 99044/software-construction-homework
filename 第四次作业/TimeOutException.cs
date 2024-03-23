namespace ConsoleApp4;

public class TimeOutException : Exception//自定义用户输入事件越界异常
{
    public TimeOutException(string message) : base(message)
    {
        
    }
}