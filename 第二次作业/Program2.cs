
namespace ConsoleApp2;

public class Program2
{
    //上下限，中间取素数
    private Queue<int> queue = new Queue<int>();//定义一个队列存储素数
    private int high = 0;//定义上下限
    private int low = 0;

    public bool isPrimeNumber(int n)//判断是否为素数
    {
        if (n<=1)
        {
            return false;
        }
        else
        {
            for (int i = 2; i < double.Sqrt(n); i++)
            {
                if (n%i==0)
                {
                    return false;
                }
            }
        }
        return true;
    }

    public void getALLPrimeNumber()
    {
        Console.WriteLine("please enter the high and low");
        high = int.Parse(Console.ReadLine());
        low = int.Parse(Console.ReadLine());
        for (int i = low; i < high; i++)//在上下限中寻找所有素数
        {
            if (isPrimeNumber(i))
            {
                queue.Enqueue(i);
            }

            if (queue.Count>=10)//如果队列中长度到达10时，一次将所有元素出队
            {
                while (queue.Count!=0)
                {
                    Console.Write(queue.Dequeue()+" ");
                }
                Console.WriteLine();
            }
        }
        while (queue.Count!=0)//若队中仍有剩余元素，将所有元素出队
        {
            Console.Write(queue.Dequeue()+" ");
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("请选择作业1或作业2，分别输入1和2");
        int temp = int.Parse(Console.ReadLine());
        switch (temp)
        {
            case 1:  
                GetArrayResult.Main1();
                break;
            case 2:
                Program2 process = new Program2();
                process.getALLPrimeNumber();
                break;
            default:
                Console.WriteLine("输入有误，程序结束");
                break;
        }
    }
}