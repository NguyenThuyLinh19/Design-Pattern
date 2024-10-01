using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
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
}
