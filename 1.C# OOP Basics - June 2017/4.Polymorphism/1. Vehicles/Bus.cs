public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
        this.FuelConsumption += 1.4;
    }

    public override string Drive(double distance)
    {
        var neededFuel = distance * this.FuelConsumption;
        if (neededFuel <= this.FuelQuantity)
        {
            this.FuelQuantity -= neededFuel;
            return $"{nameof(Bus)} travelled {distance} km";
        }
        else
        {
            return $"{nameof(Bus)} needs refueling";
        }
    }

    public string DriveEmpty(double distance)
    {
        this.FuelConsumption -= 1.4;
        var result = this.Drive(distance);
        this.FuelConsumption += 1.4;

        return result;
    }
    
    public override string ToString()
    {
        return $"{nameof(Bus)}: {this.FuelQuantity:f2}";
    }
}