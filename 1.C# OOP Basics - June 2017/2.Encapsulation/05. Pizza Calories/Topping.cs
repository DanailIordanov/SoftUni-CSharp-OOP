using System;

public class Topping
{
    private string type;
    private int weight;

    public Topping(string toppingType, int weight)
    {
        this.Type = toppingType;
        this.Weight = weight;
        this.TotalCalories = GetCalories(weight, toppingType);
    }

    public decimal TotalCalories { get; private set; }

    private string Type
    {
        set
        {
            if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
            {
                throw new Exception($"Cannot place {value} on top of your pizza.");
            }

            this.type = value;
        }
    }

    private int Weight
    {
        set
        {
            if (value < 1 || value > 50)
            {
                throw new Exception($"{this.type} weight should be in the range [1..50].");
            }

            this.weight = value;
        }
    }

    private decimal GetCalories(int weight, string toppingType)
    {
        var modifier = 2.0m;

        switch (toppingType.ToLower())
        {
            case "meat":
                modifier *= 1.2m;
                break;
            case "veggies":
                modifier *= 0.8m;
                break;
            case "cheese":
                modifier *= 1.1m;
                break;
            case "sauce":
                modifier *= 0.9m;
                break;
        }

        return modifier * weight;
    }

}