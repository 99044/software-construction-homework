namespace ConsoleApp4;

public class AlarmClock
{
    public event EventHandler<EventArgs> Tick; // 嘀嗒事件
    public event EventHandler<EventArgs> Clock;// 响铃时间
    
    // 触发嘀嗒事件
    protected virtual void OnTick(string message)
    {
        Tick?.Invoke(this, new AlarmEvent(message));
        Console.WriteLine(message);
    }

    // 触发响铃事件
    protected virtual void OnAlarm(string message)
    {
        Clock?.Invoke(this, new AlarmEvent(message));
        Console.WriteLine(message);
    }

    public void Start(int hour,int minute)
    {
        while (true)
        {
            // 获取当前时间
            DateTime currentTime = DateTime.Now;
            // 判断是否到达对应时间
            if (currentTime.Hour==hour && currentTime.Minute==minute)
            {
                //触发响铃事件
                OnAlarm("Clock!");
                break;
            }
            // 触发滴答事件
            OnTick("Current time : "+currentTime.ToString("HH:mm:ss"));
            Thread.Sleep(1000); // 等待1秒
        }
    }
    
}