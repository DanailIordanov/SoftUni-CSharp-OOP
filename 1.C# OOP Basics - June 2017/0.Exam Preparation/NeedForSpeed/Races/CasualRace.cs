﻿using System;
using System.Collections.Generic;

public class CasualRace : Race
{
    public CasualRace(int length, string route, int prizePool) : base(length, route, prizePool)
    {
    }

    public override void GetPerformancePints(IEnumerable<Car> carsCollection)
    {
        foreach (var car in carsCollection)
        {
            car.PerformancePoints = (car.Horsepower / car.Acceleration) + (car.Suspension + car.Durability);
        }
    }
}