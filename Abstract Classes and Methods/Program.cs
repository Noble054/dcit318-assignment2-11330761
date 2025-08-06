using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    public float radius;
    const float PI = 3.14159f;

    public Circle(float radius)
    {
        this.radius = radius;
    }

    public override double GetArea() 
    {
        return PI * radius * radius;
    }
}

class Rectangle : Shape
{
    public double width, length;

    public Rectangle(double width, double length) 
    {
        this.width = width;
        this.length = length;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(5, 7); 
        Circle circle = new Circle(9);

        Console.WriteLine("The area of the rectangle is " + rectangle.GetArea());
        Console.WriteLine("The area of the circle is " + circle.GetArea());

        Console.WriteLine("Press any key to exit ..");
        Console.ReadKey();
    }
}
