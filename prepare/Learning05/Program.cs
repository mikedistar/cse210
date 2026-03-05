using System;

class Program
{
    static void Main(string[] args)
    {

        Square square = new Square(2, "red");
        Rectangle rectangle = new Rectangle(3, 2, "blue");
        Circle circle = new Circle(1, "yellow");
    
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);


        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"There is a {shape.GetColor()} shape.");
            Console.WriteLine($"It's area is {shape.GetArea()}.");
            Console.WriteLine("");
        }
    }
}