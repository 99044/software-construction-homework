// See https://aka.ms/new-console-template for more information

using System.Collections;
using ConsoleApp5;

public class program
{
    public static void Main(string[] args)
    {
        int temp=0;
        Console.WriteLine("请输入1或2，分别代表作业的第一部分和第二部分");
        bool isRight = true;
        while (isRight)
        {
            try
            {
                temp = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("输入有误，要求输入1或2，请重新输入");
            }
            finally
            {
                if (temp==1 || temp ==2)
                {
                    isRight = false;
                }
                else
                {
                    Console.WriteLine("输入有误，要求输入1或2，请重新输入");
                }
            }

            switch (temp)
            {
                case 1:
                    Goldbach goldbach = new Goldbach();
                    BitArray bitArrays = new BitArray(101, true);
                    goldbach.isPrimeNumber(bitArrays);
                    goldbach.getPrimeNumber(bitArrays,6,100);
                    break;
                case 2:
                    Random random = new Random();
                    int[] numbers = new int[100];//用来存储一百个随机数
                    for (int i=0;i<numbers.Length;i++)//对随机数数组赋初值
                    {
                        numbers[i] = random.Next(0, 1001);
                    }
                    var sortedNumbers = numbers.OrderByDescending(n => n);//对数组进行降序排序操作
                    var sum = sortedNumbers.Sum();//求和
                    var average = sortedNumbers.Average();//求均值

                    Console.WriteLine("降序排序后的数组:");
                    foreach (var number in sortedNumbers)//输出随机数数组
                    {
                        Console.Write(number + " ");
                    }

                    Console.WriteLine($"\n\n和: {sum}");
                    Console.WriteLine($"均值: {average}");
                    break;
            }
        }
        
        
        
        
        
        
    }
}