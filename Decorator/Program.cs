using Decorator;

class Program
{
    static void Main(string[] args)
    {
        // Cà phê cơ bản
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"{coffee.GetDescription()} - Cost: {coffee.GetCost()}");

        // Thêm sữa vào cà phê
        coffee = new MilkDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} - Cost: {coffee.GetCost()}");

        // Thêm đường vào cà phê
        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} - Cost: {coffee.GetCost()}");
    }
}
