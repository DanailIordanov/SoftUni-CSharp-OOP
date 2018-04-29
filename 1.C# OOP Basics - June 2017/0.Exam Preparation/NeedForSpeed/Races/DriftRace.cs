using System;
using System.Collections.Generic;

public class DriftRace : Race
{
    public DriftRace(int length, string route, int prizePool) : base(length, route, prizePool)
    {
    }

    public override void GetPerformancePints(IEnumerable<Car> carsCollection)
    {
        foreach (var car in carsCollection)
        {
            car.PerformancePoints = car.Suspension + car.Durability;
        }
    }
}