using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square(10, "green"));
        shapes.Add(new Square(2.2, "blue"));
        shapes.Add(new Rectangle(100, 2, "orange"));
        shapes.Add(new Rectangle(10, 4, "red"));
        shapes.Add(new Circle(42.3, "purple"));
        shapes.Add(new Circle(2.5, "black"));

        foreach (Shape s in shapes)
            Console.WriteLine($"The {s.GetColor()} {s.GetType().ToString().ToLower()} has an area of {s.GetArea()}");
    }
}