using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    private Dictionary<int, Car> carsCollection;
    private Dictionary<int, Race> racesCollection;
    private Garage garage;

    public CarManager()
    {
        this.carsCollection = new Dictionary<int, Car>();
        this.racesCollection = new Dictionary<int, Race>();
        this.garage = new Garage();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction,
        int horsepower, int acceleration, int suspension, int durability)
    {
        if (type == "Performance")
        {
            this.carsCollection[id] = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
        }
        else
        {
            this.carsCollection[id] = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
        }
    }

    public string Check(int id)
    {
        return this.carsCollection[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        if (type == "Casual")
        {
            this.racesCollection[id] = new CasualRace(length, route, prizePool);
        }
        else if (type == "Drag")
        {
            this.racesCollection[id] = new DragRace(length, route, prizePool);
        }
        else
        {
            this.racesCollection[id] = new DriftRace(length, route, prizePool);
        }
    }

    public void Participate(int carId, int raceId)
    {
        var participant = this.carsCollection[carId];
        if (!participant.IsParked)
        {
            participant.IsInRace = true;
            this.racesCollection[raceId].Participants.Add(participant);
        }
    }

    public string Start(int id)
    {
        if (racesCollection.Any())
        {
            return this.racesCollection[id].ToString();
        }
        return "Cannot start the race with zero participants.";
    }

    public void Park(int id)
    {
        var parkedCar = carsCollection[id];
        if (!parkedCar.IsInRace)
        {
            parkedCar.IsParked = true;
            this.garage.ParkedCars.Add(parkedCar);
        }
    }

    public void Unpark(int id)
    {
        var parkedCar = carsCollection[id];
        parkedCar.IsParked = false;
        this.garage.ParkedCars.Remove(parkedCar);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        if (garage.ParkedCars.Any())
        {
            foreach (var car in this.garage.ParkedCars)
            {
                car.Horsepower += tuneIndex;
                car.Suspension += tuneIndex / 2;
            }

            if (garage.ParkedCars.Any(x => x is PerformanceCar))
            {
                foreach (PerformanceCar car in this.garage.ParkedCars.Where(x => x is PerformanceCar))
                {
                    car.AddOns.Add(addOn);
                }
            }

            if (garage.ParkedCars.Any(x => x is ShowCar))
            {
                foreach (ShowCar car in this.garage.ParkedCars.Where(x => x is ShowCar))
                {
                    car.Stars += tuneIndex;
                }
            }
        }
    }
}