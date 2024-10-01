using System;
using System.Text;
using Builder;

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Tạo bữa ăn bình thường
        IMealBuilder regularMealBuilder = new RegularMealBuilder();
        MealDirector director = new MealDirector(regularMealBuilder);
        director.MakeMeal();
        Meal regularMeal = regularMealBuilder.GetMeal();
        Console.WriteLine("Regular Meal:\n" + regularMeal.GetMealDetails());

        // Tạo bữa ăn chay
        IMealBuilder veggieMealBuilder = new VeggieMealBuilder();
        director = new MealDirector(veggieMealBuilder);
        director.MakeMeal();
        Meal veggieMeal = veggieMealBuilder.GetMeal();
        Console.WriteLine("Veggie Meal:\n" + veggieMeal.GetMealDetails());
    }
}
