using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var dictionaryOfCars = new Dictionary<string, Car>();

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split().ToArray();

            var currentCar = new Car(tokens[0], decimal.Parse(tokens[1]), decimal.Parse(tokens[2]));
            dictionaryOfCars[currentCar.Model] = currentCar;
        }

        while (true)
        {
            var line = Console.ReadLine().Split().ToArray();
            if (line[0] == "End")
            {
                break;
            }
            var currentCarName = line[1];
            var currentDistance = int.Parse(line[2]);

            if (dictionaryOfCars[currentCarName].CanMoveThatDistance(currentDistance))
            {
                dictionaryOfCars[currentCarName].MoveCar(currentDistance);
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        foreach (var car in dictionaryOfCars)
        {
            Console.WriteLine($"{car.Value.Model} {car.Value.FuelAmount:f2} {car.Value.DistanceTraveled}");
        }
    }
}
