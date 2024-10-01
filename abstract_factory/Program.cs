using System;
using abstract_factory;


// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Bối cảnh Rừng
        Console.WriteLine("Chơi trong rừng:");
        IEnvironmentFactory forestFactory = new ForestFactory();
        Game forestGame = new Game(forestFactory);
        forestGame.Play();

        // Bối cảnh Hang động
        Console.WriteLine("\nChơi trong hang động:");
        IEnvironmentFactory caveFactory = new CaveFactory();
        Game caveGame = new Game(caveFactory);
        caveGame.Play();
    }
}