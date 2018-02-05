using System;
using System.Collections.Generic;

public class Pizza
{
    private string name;
    private Dough dough;
    private List<Topping> listOfToppings;
    private int numberOfToppings;

    public Pizza(string name, int numberOfToppings)
    {
        this.Name = name;
        this.NumberOfToppings = numberOfToppings;
        this.listOfToppings = new List<Topping>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        private set
        {
            if (value == String.Empty || value.Length > 15)
            {
                throw new Exception("Pizza name should be between 1 and 15 symbols.");
            }

            this.name = value;
        }
    }

    public int NumberOfToppings
    {
        get
        {
            return this.numberOfToppings;
        }
        private set
        {
            if (value > 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }

            this.numberOfToppings = value;
        }
    }

    public Dough Dough
    {
        set
        {
            this.dough = value;
        }
    }

    public decimal TotalCalories
    {
        get
        {
            return GetTotalCalories(this.listOfToppings, this.dough);
        }
    }

    public void AddTopping(Topping topping)
    {
        listOfToppings.Add(topping);
    }

    private decimal GetTotalCalories(List<Topping> toppings, Dough dough)
    {
        var totalCalories = 0.0m;

        foreach (var topping in toppings)
        {
            totalCalories += topping.TotalCalories;
        }
        totalCalories += dough.TotalCalories;

        return totalCalories;
    }
}