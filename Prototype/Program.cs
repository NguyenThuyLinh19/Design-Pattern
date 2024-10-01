using System;
using Prototype;

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
