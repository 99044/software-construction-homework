namespace ConsoleApp3;

public class Rectangle : Shape
{
    private double length { set; get; }
    private double width { set; get; }
    public Rectangle(){}

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double Area()
    {
        return length * width;
    }

    public bool isValid()
    {
        return length > 0 && width > 0 && length >= width;
    }
}