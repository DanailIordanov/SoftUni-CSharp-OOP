using System;

public class Mouse : Mammal
{
    public Mouse(string animalName, string animalType, double animalWeight, string livingRegion) 
        : base(animalName, animalType, animalWeight, livingRegion)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("SQUEEEAAAK!");
    }
}