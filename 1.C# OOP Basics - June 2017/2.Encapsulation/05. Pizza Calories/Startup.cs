using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        try
        {
            var pizzaInfo = Console.ReadLine().Split().ToArray();
            var pizza = new Pizza(pizzaInfo[1], int.Parse(pizzaInfo[2]));

            var doughInfo = Console.ReadLine().Split().ToArray();
            pizza.Dough = new Dough(doughInfo[1], doughInfo[2], int.Parse(doughInfo[3]));

            for (int i = 0; i < pizza.NumberOfToppings; i++)
            {
                var toppingInfo = Console.ReadLine().Split().ToArray();
                pizza.AddTopping(new Topping(toppingInfo[1], int.Parse(toppingInfo[2])));
            }

            Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}