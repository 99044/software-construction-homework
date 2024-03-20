// See https://aka.ms/new-console-template for more information

using ConsoleApp3;

class MyClass
{
    public static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();//定义一个存储图形对象的数组
        // 随机创建10个形状对象
        var rand = new Random();
        for (int i = 0; i < 10; i++)
        {
            int shapeType = rand.Next(0, 3);//0,1,2分别代表三种图形
            switch (shapeType)
            {
                case 0:
                    double width = rand.Next(1, 100)+0.0;
                    double length = rand.Next(1, 100)+0.0;
                    shapes.Add(new Rectangle(length,width));
                    break;
                case 1:
                    double side = rand.Next(1, 100)+0.0;
                    shapes.Add(new Square(side));
                    break;
                case 2:
                    double radius = rand.Next(1, 100)+0.0;
                    shapes.Add(new Circle(radius));
                    break;
            }
        }
        
        // 计算这些对象的面积之和
        double totalArea = 0;//总面积
        for (int i =0; i < 10;i++)
        {
            if (shapes[i].isValid())//如果图形有效
            {
                totalArea += shapes[i].Area();
                Console.WriteLine("the No.{0} shape's area is {1}",i+1,shapes[i].Area());//打印每个图形的面积
            }
        }
        
        Console.WriteLine("the totalArea is {0}",totalArea);
    }
}