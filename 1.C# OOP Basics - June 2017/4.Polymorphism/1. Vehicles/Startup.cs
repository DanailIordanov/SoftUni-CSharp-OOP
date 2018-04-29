using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var carParams = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
        var car = new Car(carParams[0], carParams[1], carParams[2]);

        var truckParams = Console.ReadLine().Split(' ').Skip(1).Select(double.Parse).ToArray();
        var truck = new Truck(truckParams[0], truckParams[1], truckParams[2]);

        var busParams = Console.ReadLine().Split(' ').Skip(1).Select(double.Parse).ToArray();
        var bus = new Bus(busParams[0], busParams[1], busParams[2]);

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var commandArgs = Console.ReadLine().Split();
            var command = commandArgs[0];
            var vehicle = commandArgs[1];
            var amount = double.Parse(commandArgs[2]);
            try
            {
                if (command == "Drive")
                {
                    switch (vehicle)
                    {
                        case "Car": Console.WriteLine(car.Drive(amount)); break;
                        case "Truck": Console.WriteLine(truck.Drive(amount)); break;
                        case "Bus": Console.WriteLine(bus.Drive(amount)); break;
                    }
                }
                else if (command == "Refuel")
                {
                    switch (vehicle)
                    {
                        case "Car": car.Refuel(amount); break;
                        case "Truck": truck.Refuel(amount); break;
                        case "Bus": bus.Refuel(amount); break;
                    }
                }
                else
                {
                    Console.WriteLine(bus.DriveEmpty(amount));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine(car.ToString());
        Console.WriteLine(truck.ToString());
        Console.WriteLine(bus.ToString());
    }
}