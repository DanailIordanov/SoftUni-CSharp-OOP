using System;

public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private int weight;

    public Dough(string flourType, string bakingTechnique, int weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
        this.TotalCalories = GetCalories(weight, flourType, bakingTechnique);
    }

    public decimal TotalCalories { get; private set; }

    private string FlourType
    {
        set
        {
            if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
            {
                throw new Exception("Invalid type of dough.");
            }

            this.flourType = value;
        }
    }

    private string BakingTechnique
    {
        set
        {
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                throw new Exception("Invalid type of dough.");
            }

            this.bakingTechnique = value;
        }
    }

    private int Weight
    {
        set
        {
            if (value < 1 || value > 200)
            {
                throw new Exception("Dough weight should be in the range [1..200].");
            }

            this.weight = value;
        }
    }

    private static decimal GetModifier(string flourType, string bakingTechnique)
    {
        var resultModifier = 2.0m;

        switch (flourType.ToLower())
        {
            case "white":
                resultModifier *= 1.5m;
                break;
            case "wholegrain":
                resultModifier *= 1.0m;
                break;
        }

        switch (bakingTechnique.ToLower())
        {
            case "crispy":
                resultModifier *= 0.9m;
                break;
            case "chewy":
                resultModifier *= 1.1m;
                break;
            case "homemade":
                resultModifier *= 1.0m;
                break;
        }

        return resultModifier;
    }

    private static decimal GetCalories(int weight, string flourType, string bakingTechnique)
    {
        decimal modifier = GetModifier(flourType, bakingTechnique);
        return weight * modifier;
    }
}