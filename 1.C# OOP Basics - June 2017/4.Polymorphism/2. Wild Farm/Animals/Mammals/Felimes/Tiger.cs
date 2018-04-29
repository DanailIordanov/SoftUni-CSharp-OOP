using System;

public class Tiger : Felime
{
    public Tiger(string animalName, string animalType, double animalWeight, string livingRegion) 
        : base(animalName, animalType, animalWeight, livingRegion)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("ROAR!!!");
    }
}