using Flyweight;

class Program
{
    static void Main(string[] args)
    {
        CircleFactory factory = new CircleFactory();

        // Sử dụng các hình tròn với cùng màu sắc, chỉ thay đổi tọa độ
        ICircle redCircle = factory.GetCircle("Red");
        redCircle.Draw(10, 20);

        ICircle blueCircle = factory.GetCircle("Blue");
        blueCircle.Draw(15, 25);

        ICircle redCircle2 = factory.GetCircle("Red");
        redCircle2.Draw(30, 40);  // Dùng lại đối tượng redCircle

        ICircle blueCircle2 = factory.GetCircle("Blue");
        blueCircle2.Draw(50, 60);  // Dùng lại đối tượng blueCircle
    }
}
