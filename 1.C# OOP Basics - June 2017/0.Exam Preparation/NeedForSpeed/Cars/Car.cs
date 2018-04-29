using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int acceleration;
    private int suspension;
    private int durability;

    public Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.brand = brand;
        this.model = model;
        this.yearOfProduction = yearOfProduction;
        this.horsepower = horsepower;
        this.acceleration = acceleration;
        this.suspension = suspension;
        this.durability = durability;
        this.IsInRace = false;
        this.IsParked = false;
    }
    
    public string Brand => this.brand;
    public string Model => this.model;
    public int YearOfProduction => this.yearOfProduction;
    public int Horsepower
    {
        get { return this.horsepower; }
        set { this.horsepower = value; }
    }
    public int Acceleration => this.acceleration;
    public int Suspension
    {
        get { return this.suspension; }
        set { this.suspension = value; }
    }
    public int Durability => this.durability;
    public bool IsInRace { get; set; }
    public bool IsParked { get; set; }
    public int PerformancePoints { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.brand} {this.model} {this.yearOfProduction}");
        sb.AppendLine($"{this.horsepower} HP, 100 m/h in {this.acceleration} s");
        sb.AppendLine($"{this.suspension} Suspension force, {this.durability} Durability");
        return sb.ToString();
    }
}