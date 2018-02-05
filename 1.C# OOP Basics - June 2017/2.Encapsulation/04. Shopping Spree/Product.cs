using System;

public class Product
{
    private string name;
    private int cost;

    public Product(string name, int cost)
    {
        this.Name = name;
        this.Cost = cost;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        private set
        {
            if (value.Trim().Length == 0)
            {
                throw new Exception("Name cannot be empty");
            }
            this.name = value;
        }
    }

    public int Cost
    {
        get
        {
            return this.cost;
        }
        private set
        {
            if (value < 0)
            {
                throw new Exception("Money cannot be negative");
            }
            this.cost = value;
        }
    }
}