public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override string Drive(double distance)
    {
        var neededFuel = distance * this.FuelConsumption;
        if (neededFuel <= this.FuelQuantity)
        {
            this.FuelQuantity -= neededFuel;
            return $"{nameof(Car)} travelled {distance} km";
        }
        else
        {
            return $"{nameof(Car)} needs refueling";
        }
    }
    
    public override string ToString()
    {
        return $"{nameof(Car)}: {this.FuelQuantity:f2}";
    }
}