using Bridge;

class Program
{
    static void Main(string[] args)
    {
        // Vẽ hình tròn bằng bút chì
        Shape circleWithPencil = new Circle(new Pencil());
        circleWithPencil.Draw();

        // Vẽ hình vuông bằng bút mực
        Shape squareWithInkPen = new Square(new InkPen());
        squareWithInkPen.Draw();
    }
}
