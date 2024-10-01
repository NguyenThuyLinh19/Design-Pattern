using Proxy;

class Program
{
    static void Main(string[] args)
    {
        IImage image = new ProxyImage("test_image.jpg");

        // Hình ảnh chỉ được tải khi gọi phương thức Display
        Console.WriteLine("Image will be displayed now:");
        image.Display();  // Hình ảnh được tải và hiển thị

        Console.WriteLine("\nImage will be displayed again:");
        image.Display();  // Hình ảnh được hiển thị mà không cần tải lại
    }
}
