using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var index = 0;
        Animal animal = null;
        Food food = null;


        while (inputLine != "End")
        {
            var inputArgs = inputLine.Split().ToArray();

            if (index % 2 == 0)
            {
                var animalType = inputArgs[0];
                var animalName = inputArgs[1];
                var animalWeight = double.Parse(inputArgs[2]);
                var animalLivingRegion = inputArgs[3];

                if (animalType == "Mouse")
                {
                    animal = new Mouse(animalName, animalType, animalWeight, animalLivingRegion);
                }
                else if (animalType == "Cat")
                {
                    var breed = inputArgs[4];
                    animal = new Cat(animalName, animalType, animalWeight, animalLivingRegion, breed);
                }
                else if (animalType == "Tiger")
                {
                    animal = new Tiger(animalName, animalType, animalWeight, animalLivingRegion);
                }
                else if (animalType == "Zebra")
                {
                    animal = new Zebra(animalName, animalType, animalWeight, animalLivingRegion);
                }

                animal.MakeSound();
            }
            else
            {
                var foodType = inputArgs[0];
                var quantity = int.Parse(inputArgs[1]);

                if (foodType == "Vegetable" && (animal.AnimalType == "Mouse" || animal.AnimalType == "Zebra"))
                {
                    food = new Vegetable(quantity);
                    animal.Eat(food);
                }
                else if (foodType == "Meat" && animal.AnimalType == "Tiger")
                {
                    food = new Meat(quantity);
                    animal.Eat(food);
                } 
                else if (animal.AnimalType == "Cat")
                {
                    if (foodType == "Vegetable")
                    {
                        food = new Vegetable(quantity);
                    }
                    else if (foodType == "Meat")
                    {
                        food = new Meat(quantity);
                    }
                    animal.Eat(food);
                }
                else
                {
                    Console.WriteLine($"{animal.AnimalType}s are not eating that type of food!");
                }

                Console.WriteLine(animal.ToString());
            }

            index++;
            inputLine = Console.ReadLine();
        }
    }
}