using System;

public abstract class Vehicle
{
    public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
        this.TankCapacity = tankCapacity;
    }

    public double FuelQuantity { get; protected set; }

    public double FuelConsumption { get; protected set; }

    public double TankCapacity { get; protected set; }

    public abstract string Drive(double distance);

    public virtual void Refuel(double liters)
    {
        var value = liters + this.FuelQuantity;
        if (value > this.TankCapacity)
        {
            throw new Exception($"Cannot fit {liters} fuel in the tank");
        }
        else if (liters <= 0)
        {
            throw new Exception("Fuel must be a positive number");
        }

        this.FuelQuantity += liters;
    }
}