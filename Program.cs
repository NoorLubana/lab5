using System;

public class Circle
{
    private double radius;

    public double Radius
    {
        get { return radius; }
    }

    public Circle(double radius)
    {
        SetRadius(radius);
    }

    public void SetRadius(double newRadius)
    {
        if (newRadius > 0)
        {
            radius = newRadius;
        }
        else
        {
            throw new InvalidRadiusException(newRadius);
        }
    }

    public override string ToString()
    {
        return $"Circle with radius {Radius}";
    }
}

public class InvalidRadiusException : Exception
{
    public InvalidRadiusException() : base("Invalid radius: radius must be greater than zero") { }

    public InvalidRadiusException(double radius) : base($"Invalid radius: {radius} is not greater than zero") { }
}

class MainClass
{
    public static void Main(string[] args)
    {
        try
        {
            Circle circle1 = new Circle(5);
            Console.WriteLine($"Radius of circle1: {circle1.Radius}");

            Circle circle2 = new Circle(-3);
            Console.WriteLine($"Radius of circle2: {circle2.Radius}");
        }
        catch (InvalidRadiusException e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            Circle circle3 = new Circle(0);
            Console.WriteLine($"Radius of circle3: {circle3.Radius}");
        }
        catch (InvalidRadiusException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
