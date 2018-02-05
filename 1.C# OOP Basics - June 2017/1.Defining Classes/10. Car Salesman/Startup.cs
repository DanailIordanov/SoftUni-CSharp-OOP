using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var listOfEngines = new List<Engine>();

        for (int i = 0; i < n; i++)
        {
            var engineTokens = Console.ReadLine().Split().ToArray();
            var currentEngine = new Engine(engineTokens[0], int.Parse(engineTokens[1]));
            if (engineTokens.Length > 2)
            {
                if (int.TryParse(engineTokens[2], out int engineDisplacement))
                {
                    currentEngine.Displacement = engineDisplacement;
                }
                else
                {
                    currentEngine.Efficiency = engineTokens[2];
                }
            }
            if (engineTokens.Length > 3)
            {
                currentEngine.Efficiency = engineTokens[3];
            }

            listOfEngines.Add(currentEngine);
        }

        var m = int.Parse(Console.ReadLine());
        var listOfCars = new List<Car>();

        for (int i = 0; i < m; i++)
        {
            var carTokens = Console.ReadLine().Split().ToArray();
            var currentCar = new Car(carTokens[0], listOfEngines[listOfEngines.FindIndex(x => x.Model == carTokens[1])]);
            if (carTokens.Length > 2)
            {
                if (int.TryParse(carTokens[2], out int carWeight))
                {
                    currentCar.Weight = carWeight;
                }
                else
                {
                    currentCar.Color = carTokens[2];
                }
            }
            if (carTokens.Length > 3 && carTokens[carTokens.Length - 1] != String.Empty)
            {
                currentCar.Color = carTokens[3];
            }

            listOfCars.Add(currentCar);
        }

        foreach (var car in listOfCars)
        {
            Console.WriteLine($"{car.Model}:");
            Console.WriteLine($"  {car.Engine.Model}:");
            Console.WriteLine($"    Power: {car.Engine.Power}");
            string engineDisplacement = car.Engine.Displacement != 0 ? $"{car.Engine.Displacement}" : "n/a";
            Console.WriteLine($"    Displacement: {engineDisplacement}");
            Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
            string carWeight = car.Weight != 0 ? $"{car.Weight}" : "n/a";
            Console.WriteLine($"  Weight: {carWeight}");
            Console.WriteLine($"  Color: {car.Color}");
        }
    }
}