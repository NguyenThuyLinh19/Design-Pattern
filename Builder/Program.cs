using System;
using System.Text;

// Product - Meal (Bữa ăn)
public class Meal
{
    private StringBuilder items = new StringBuilder();

    public void AddItem(string item)
    {
        items.Append(item + "\n");
    }

    public string GetMealDetails()
    {
        return items.ToString();
    }
}

// Abstract Builder - IMealBuilder (Giao diện để xây dựng bữa ăn)
public interface IMealBuilder
{
    void BuildBurger();
    void BuildFries();
    void BuildDrink();
    Meal GetMeal();
}

// Concrete Builder - RegularMealBuilder (Xây dựng bữa ăn bình thường)
public class RegularMealBuilder : IMealBuilder
{
    private Meal meal = new Meal();

    public void BuildBurger()
    {
        meal.AddItem("Regular Hamburger");
    }

    public void BuildFries()
    {
        meal.AddItem("Regular Fries");
    }

    public void BuildDrink()
    {
        meal.AddItem("Coke");
    }

    public Meal GetMeal()
    {
        return meal;
    }
}

// Concrete Builder - VeggieMealBuilder (Xây dựng bữa ăn chay)
public class VeggieMealBuilder : IMealBuilder
{
    private Meal meal = new Meal();

    public void BuildBurger()
    {
        meal.AddItem("Veggie Burger");
    }

    public void BuildFries()
    {
        meal.AddItem("Sweet Potato Fries");
    }

    public void BuildDrink()
    {
        meal.AddItem("Orange Juice");
    }

    public Meal GetMeal()
    {
        return meal;
    }
}

// Director - MealDirector (Quản lý việc xây dựng bữa ăn)
public class MealDirector
{
    private IMealBuilder _mealBuilder;

    public MealDirector(IMealBuilder mealBuilder)
    {
        _mealBuilder = mealBuilder;
    }

    public void MakeMeal()
    {
        _mealBuilder.BuildBurger();
        _mealBuilder.BuildFries();
        _mealBuilder.BuildDrink();
    }
}

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
