using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.Horsepower += horsepower / 2;
        this.Suspension -= suspension / 4;
        this.addOns = new List<string>();
    }

    public List<String> AddOns
    {
        get { return this.addOns; }
        set { this.addOns = value; }
    }

    public override string ToString()
    {
        var sb = new StringBuilder(base.ToString());

        if (!addOns.Any())
        {
            sb.AppendLine("Add-ons: None");
            return sb.ToString();
        }

        sb.Append($"Add-ons: ");
        sb.AppendLine(String.Join(", ", this.AddOns));
        return sb.ToString();
    }
}