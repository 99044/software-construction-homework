namespace ConsoleApp3;

public class Circle : Shape
{
    private double radius {  get; set; }
    public Circle(){}

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public bool isValid()
    {
        return radius > 0;
    }

    public double Area()
    {
        return Math.PI * radius * radius;
    }
}