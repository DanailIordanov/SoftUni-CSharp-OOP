public class Car
{
    private string model;
    private int speed;

    public Car(string model, int speed)
    {
        this.Model = model;
        this.Speed = speed;
    }

    public string Model
    {
        get => this.model;
        private set => this.model = value;
    }

    public int Speed
    {
        get => this.speed;
        private set => this.speed = value;
    }
}