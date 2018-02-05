using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var carsCollection = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            
            var line = Console.ReadLine().Split().ToArray();

            var model = line[0];
            var engineSpeed = int.Parse(line[1]);
            var enginePower = int.Parse(line[2]);
            var cargoWeight = int.Parse(line[3]);
            var cargoType = line[4];

            var currentTires = new Tires();
            
            var tiresCollection = new List<Tires>();

            var isLess = false;

            for (int j = 5; j < line.Length; j++)
            {
                if (j % 2 == 1)
                {
                    currentTires = new Tires();
                    currentTires.Pressure = double.Parse(line[j]);
                    if (currentTires.Pressure < 1)
                    {
                        isLess = true;
                    }
                }
                else
                {
                    currentTires.Age = int.Parse(line[j]);
                    tiresCollection.Add(currentTires);
                }
            }

            var currentCar = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tiresCollection, isLess);
            carsCollection.Add(currentCar);
            
        }

        var command = Console.ReadLine();
        if (command == "fragile")
        {
            foreach (var car in carsCollection)
            {
                if (car.Cargo.Type == "fragile" && car.IsLess == true)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
        else
        {
            foreach (var car in carsCollection)
            {
                if (car.Cargo.Type == "flamable" && car.Engine.Power > 250)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
