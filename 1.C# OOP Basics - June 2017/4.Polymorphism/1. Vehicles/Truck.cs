public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
        this.FuelConsumption += 1.6;
    }

    public override string Drive(double distance)
    {
        var neededFuel = distance * this.FuelConsumption;
        if (neededFuel <= this.FuelQuantity)
        {
            this.FuelQuantity -= neededFuel;
            return $"{nameof(Truck)} travelled {distance} km";
        }
        else
        {
            return $"{nameof(Truck)} needs refueling";
        }
    }

    public override void Refuel(double liters)
    {
        base.Refuel(liters);
        this.FuelQuantity -= liters * 0.05;
    }

    public override string ToString()
    {
        return $"{nameof(Truck)}: {this.FuelQuantity:f2}";
    }
}