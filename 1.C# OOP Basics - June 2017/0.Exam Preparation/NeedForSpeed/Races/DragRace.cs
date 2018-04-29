using System;
using System.Collections.Generic;

public class DragRace : Race
{
    public DragRace(int length, string route, int prizePool) : base(length, route, prizePool)
    {
    }

    public override void GetPerformancePints(IEnumerable<Car> carsCollection)
    {
        foreach (var car in carsCollection)
        {
            car.PerformancePoints = car.Horsepower / car.Acceleration;
        }
    }
}