// See https://aka.ms/new-console-template for more information


using System.Xml.Serialization;

public class GetArrayResult
{
    public int length=1;
    public int[] num;
    public int getArrayMax(GetArrayResult array)//获取数组最大值
    {
        int temp = 0;
        for (int i = 0; i < array.length; i++)
        {
            if (array.num[temp]<array.num[i])
            {
                temp = i;
            }
        }
        return temp;
    }

    public int getArrayMin(GetArrayResult array)//获取数组最小值
    {
        int temp = 0;
        for (int i = 0; i < array.length; i++)
        {
            if (array.num[temp]>array.num[i])
            {
                temp = i;
            }
        }
        return temp;
    }

    public double getArrayAverage(GetArrayResult array)//获取数组均值
    {
        return (getArraySum(array)+0.0)/array.length;
    }

    public double getArraySum(GetArrayResult array)//获取数组元素之和
    {
        int sum = 0;
        for (int i = 0; i < array.length; i++)
        {
            sum += array.num[i];
        }

        return sum;
    }

    public static void Main1()
    {
        GetArrayResult array = new GetArrayResult();//定义一个数组对象
        Console.WriteLine("Please enter the length of array");
        array.length=int.Parse(Console.ReadLine());//用户输入数组长度
        array.num= new int[array.length];
        Console.WriteLine("Please enter all the num of array");
        for (int i = 0; i < array.length; i++)//读取数组所有元素
        {
            array.num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("select a number,the number 1 represents task one,and so on");
        //int case=int.Parse(Console.ReadLine());
        int ordinal = int.Parse(Console.ReadLine());//根据任务序号选择执行哪个任务
        switch (ordinal)
        {
            case 1:
                int temp1=array.getArrayMax(array);
                Console.WriteLine("the Max is No.{0}:{1}",temp1.ToString(),array.num[temp1].ToString());
                break;
            case 2:
                int temp2=array.getArrayMin(array);
                Console.WriteLine("the Min is No.{0}:{1}",temp2.ToString(),array.num[temp2].ToString());
                break;
            case 3:
                Console.WriteLine("the average of the array is {0}",array.getArrayAverage(array).ToString());
                break;
            case 4:
                Console.WriteLine("the sum of the array is {0}",array.getArraySum(array).ToString());
                break;
        }
        

    }
}