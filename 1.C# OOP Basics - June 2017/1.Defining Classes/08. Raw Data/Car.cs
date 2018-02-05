using System.Collections.Generic;

public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private List<Tires> tires;
    private bool tireIsLess;

    public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, List<Tires> tires, bool isLess)
    {
        this.model = model;
        this.Engine = new Engine();
        this.Engine.Speed = engineSpeed;
        this.Engine.Power = enginePower;
        this.Cargo = new Cargo();
        this.Cargo.Weight = cargoWeight;
        this.Cargo.Type = cargoType;
        this.tires = new List<Tires>();
        this.tires = tires;
        this.tireIsLess = isLess;
    }

    public Engine Engine
    {
        get { return this.engine; }
        set { this.engine = value; }
    }

    public Cargo Cargo
    {
        get { return this.cargo; }
        set { this.cargo = value; }
    }

    public bool IsLess => this.tireIsLess;

    public string Model => this.model;
}
