using System;

public class Cat : Felime
{
    public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string breed) 
        : base(animalName, animalType, animalWeight, livingRegion)
    {
        this.Breed = breed;
    }

    public string Breed { get; set; }

    public override void MakeSound()
    {
        Console.WriteLine("Meowwww");
    }

    public override string ToString()
    {
        return $"{this.AnimalType} [{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}