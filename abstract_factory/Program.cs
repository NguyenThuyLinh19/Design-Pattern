using System;

//Abstract_product: định nghĩa chung các hành vi của quái vật và môi trường
public interface IMonster
{
    void Attack();
}

public interface IWeapon
{
    void Use();
}
//Concrete_product: Các lớp thực hiện các hành vi trên Abstract product
public class Wolf : IMonster
{
    public void Attack()
    {
        Console.WriteLine("Con sói cắn");
    }
}

public class Dragon : IMonster
{
    public void Attack()
    {
        Console.WriteLine("Con rồng phun lữa");
    }
}

public class Bow : IWeapon
{
    public void Use()
    {
        Console.WriteLine("Cung tên bắn ra mũi tên");
    }
}

public class Sword : IWeapon
{
    public void Use()
    {
        Console.WriteLine("Kiếm dùng để chém");
    }
}

//Abstract factory: định nghĩa một giao tiếp cho các giao tác. môi trường để tạo ra quái vật và vũ khí
public interface IEnvironmentFactory
{
    IMonster CreateMonster();
    IWeapon CreateWeapon();
}

//Concrete factory: thực thi giao tiếp Abstract factory để tạo ra quái vật và vũ khí 
public class ForestFactory : IEnvironmentFactory
{
    public IMonster CreateMonster()
    {
        return new Wolf();
    }

    public IWeapon CreateWeapon()
    {
        return new Bow();
    }
}

public class CaveFactory : IEnvironmentFactory
{
    public IMonster CreateMonster()
    {
        return new Dragon();
    }

    public IWeapon CreateWeapon()
    {
        return new Sword();
    }
}

// Client sử dụng Abstract Factory
public class Game
{
    private IMonster _monster;
    private IWeapon _weapon;

    public Game(IEnvironmentFactory factory)
    {
        _monster = factory.CreateMonster();
        _weapon = factory.CreateWeapon();
    }

    public void Play()
    {
        _monster.Attack();
        _weapon.Use();
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Bối cảnh Rừng
        Console.WriteLine("Đang chơi trong rừng:");
        IEnvironmentFactory forestFactory = new ForestFactory();
        Game forestGame = new Game(forestFactory);
        forestGame.Play();

        // Bối cảnh Hang động
        Console.WriteLine("\nĐang chơi trong hang động:");
        IEnvironmentFactory caveFactory = new CaveFactory();
        Game caveGame = new Game(caveFactory);
        caveGame.Play();
    }
}