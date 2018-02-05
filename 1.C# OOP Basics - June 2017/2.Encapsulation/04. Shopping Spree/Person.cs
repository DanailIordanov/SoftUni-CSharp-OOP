using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private int money;
    public List<Product> BagOfProducts { get; set; }

    public Person(string name, int money)
    {
        this.Name = name;
        this.Money = money;
        this.BagOfProducts = new List<Product>();
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

    public int Money
    {
        get
        {
            return this.money;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Money cannot be negative");
            }
            this.money = value;
        }
    }
}