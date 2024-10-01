using Composite;

class Program
{
    static void Main(string[] args)
    {
        // Tạo các nhân viên
        Employee employee1 = new Employee("Hoài Hận", "Developer");
        Employee employee2 = new Employee("Thiên Hào", "Designer");

        // Tạo trưởng phòng
        Manager manager = new Manager("Thùy Linh", "Team Leader");

        // Thêm nhân viên dưới quyền của trưởng phòng
        manager.AddSubordinate(employee1);
        manager.AddSubordinate(employee2);

        // Hiển thị thông tin trưởng phòng và nhân viên
        manager.ShowDetails();
    }
}
