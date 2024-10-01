using System;
using Singleton;
// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Lấy thể hiện duy nhất của Logger
        Logger logger1 = Logger.GetInstance();
        logger1.Log("First log message.");

        // Thử lấy thể hiện lần nữa (vẫn sẽ là cùng một thể hiện)
        Logger logger2 = Logger.GetInstance();
        logger2.Log("Second log message.");

        // Kiểm tra xem cả hai logger có cùng một thể hiện hay không
        if (logger1 == logger2)
        {
            Console.WriteLine("Both logger1 and logger2 are the same instance.");
        }
    }
}
