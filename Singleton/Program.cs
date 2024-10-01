using System;

// Singleton class - Logger
public class Logger
{
    // Biến static chứa thể hiện duy nhất của Logger
    private static Logger _instance;

    // Biến static để đảm bảo đa luồng (thread-safety)
    private static readonly object _lock = new object();

    // Phương thức private constructor để ngăn không cho tạo đối tượng từ bên ngoài
    private Logger()
    {
        Console.WriteLine("Logger initialized.");
    }

    // Phương thức static để lấy thể hiện duy nhất của Logger
    public static Logger GetInstance()
    {
        // Đảm bảo chỉ một thread có thể truy cập tại một thời điểm
        lock (_lock)
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
        }
        return _instance;
    }

    // Phương thức ghi log
    public void Log(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}

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
