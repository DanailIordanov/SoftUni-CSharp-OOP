using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Person
{
    private string name;
    private Company company;
    private List<Pokemeon> pokemeons;
    private List<Parent> parents;
    private List<Child> children;
    private Car car;

    public Person(string name)
    {
        this.Name = name;
        this.Pokemeons = new List<Pokemeon>();
        this.Parents = new List<Parent>();
        this.Children = new List<Child>();
    }

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }

    public Company Company
    {
        get => this.company;
        set => this.company = value;
    }
    public List<Pokemeon> Pokemeons
    {
        get => this.pokemeons;
        set => this.pokemeons = value;
    }

    public List<Parent> Parents
    {
        get => this.parents;
        set => this.parents = value;
    }

    public List<Child> Children
    {
        get => this.children;
        set => this.children = value;
    }

    public Car Car
    {
        get => this.car;
        set => this.car = value;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        
        sb.AppendLine(this.Name);

        sb.AppendLine("Company:");
        if (this.Company != null)
        {
            sb.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary:f2}");
        }

        sb.AppendLine("Car:");
        if (this.Car != null)
        {
            sb.AppendLine($"{this.Car.Model} {this.Car.Speed}");
        }

        sb.AppendLine("Pokemon:");
        if (this.Pokemeons.Any())
        {
            foreach (var pokemon in this.Pokemeons)
            {
                sb.AppendLine($"{pokemon.Name} {pokemon.Type}");
            }
        }

        sb.AppendLine("Parents:");
        if (this.Parents.Any())
        {
            foreach (var parent in this.Parents)
            {
                sb.AppendLine($"{parent.Name} {parent.Birthday}");
            }
        }

        sb.AppendLine("Children:");
        if (this.Children.Any())
        {
            foreach (var child in this.Children)
            {
                sb.AppendLine($"{child.Name} {child.Birthday}");
            }
        }

        return sb.ToString();
    }
}