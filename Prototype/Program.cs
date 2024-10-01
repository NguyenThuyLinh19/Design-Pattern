using System;

// Prototype - Shape (Hình dạng)
public abstract class Shape
{
    public string Color { get; set; }

    // Phương thức Clone để sao chép đối tượng
    public abstract Shape Clone();
}

// Concrete Prototype - Circle (Hình tròn)
public class Circle : Shape
{
    public int Radius { get; set; }

    public Circle(int radius, string color)
    {
        this.Radius = radius;
        this.Color = color;
    }

    // Sao chép đối tượng hình tròn
    public override Shape Clone()
    {
        return new Circle(this.Radius, this.Color);
    }

    public void Display()
    {
        Console.WriteLine($"Circle: Radius = {Radius}, Color = {Color}");
    }
}

// Concrete Prototype - Square (Hình vuông)
public class Square : Shape
{
    public int SideLength { get; set; }

    public Square(int sideLength, string color)
    {
        this.SideLength = sideLength;
        this.Color = color;
    }

    // Sao chép đối tượng hình vuông
    public override Shape Clone()
    {
        return new Square(this.SideLength, this.Color);
    }

    public void Display()
    {
        Console.WriteLine($"Square: Side Length = {SideLength}, Color = {Color}");
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng hình tròn gốc
        Circle originalCircle = new Circle(5, "Red");
        originalCircle.Display();

        // Sao chép đối tượng hình tròn
        Circle clonedCircle = (Circle)originalCircle.Clone();
        clonedCircle.Display();

        // Thay đổi màu sắc của đối tượng sao chép
        clonedCircle.Color = "Blue";
        Console.WriteLine("\nAfter changing the color of the cloned circle:");
        originalCircle.Display();
        clonedCircle.Display();

        // Tạo đối tượng hình vuông gốc
        Square originalSquare = new Square(10, "Green");
        originalSquare.Display();

        // Sao chép đối tượng hình vuông
        Square clonedSquare = (Square)originalSquare.Clone();
        clonedSquare.Display();
    }
}
