public abstract class Animal
{
    public Animal(string animalName, string animalType, double animalWeight)
    {
        this.AnimalName = animalName;
        this.AnimalType = animalType;
        this.AnimalWeight = animalWeight;
    }

    public string AnimalName { get; set; }

    public string AnimalType { get; set; }

    public double AnimalWeight { get; set; }

    public int FoodEaten { get; set; }

    public abstract void MakeSound();

    public void Eat(Food food)
    {
        this.FoodEaten += food.Quantity;
    }
}