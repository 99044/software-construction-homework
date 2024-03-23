// See https://aka.ms/new-console-template for more information

using ConsoleApp4;

public class Program
{
    public static void Main(string[] args)
    {
        int hour=-1;//声明闹钟要设置的小时和分钟
        int minute=-1;
        Console.WriteLine("Set the alarm's time.");
        bool temp=true;//定义正确标签
        while (temp)//开始读取用户输入的小时
        {
            Console.WriteLine("Hour:");
            try
            {
                hour = int.Parse(Console.ReadLine());//录入小时
                if (hour < 0 || hour >= 24)//当范围越界时抛出异常
                {
                    throw new TimeoutException("the hour must be between 0 and 23.");
                }
            }
            catch (FormatException e)//输入格式异常
            {
                Console.WriteLine("please enter the hour correctly");
            }
            catch (TimeoutException e)//输入范围异常
            {
                Console.WriteLine(e.Message);
            }
            finally//判断小时正确性，若正确则跳出小时录入
            {
                if ( hour>=0 && hour<24 )
                {
                    temp = false;
                }
            }
        }

        temp = true;//恢复正确标签
        while (temp)//开始录入用户输入的分钟
        {
            Console.WriteLine("Minute:");
            try
            {
                minute = int.Parse(Console.ReadLine());//录入用户输入的分钟
                if (minute < 0 || minute >= 60)//规定正确范围
                {
                    throw new TimeoutException("the minute must be between 0 and 59.");
                }
            }
            catch (FormatException e)//输入格式异常
            {
                Console.WriteLine("please enter the minute correctly");
            }
            catch (TimeoutException e)//输入范围异常
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if ( minute>=0 && minute<60 )
                {
                    temp = false;
                }
            }
        }

        AlarmClock alarm = new AlarmClock();//创建闹钟对象
        alarm.Start(hour,minute);//设置闹钟成功，等待事件响应

    }
}