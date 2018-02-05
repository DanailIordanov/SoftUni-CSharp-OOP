using System;

public class Car
{
    private string model;
    private decimal fuelAmount;
    private decimal fuelConsumption;
    private int distanceTraveled;

    public Car(string model, decimal fuelAmount, decimal fuelConsumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
        this.distanceTraveled = 0;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }
    public decimal FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }
    public decimal FuelConsumption
    {
        get { return this.fuelConsumption; }
        set { this.fuelConsumption = value; }
    }
    public int DistanceTraveled
    {
        get { return this.distanceTraveled; }
        set { this.distanceTraveled = value; }
    }

    public bool CanMoveThatDistance(int distance)
    {
        
        if (distance * this.FuelConsumption <= this.FuelAmount && distance * this.FuelConsumption >= 0)
        {
            return true;
        }

        return false;
    }

    public void MoveCar(int distance)
    {
        this.FuelAmount -= distance * this.fuelConsumption;
        this.DistanceTraveled += distance;
    }
}
