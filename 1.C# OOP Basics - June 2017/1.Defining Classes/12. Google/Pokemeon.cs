public class Pokemeon
{
    private string name;
    private string type;

    public Pokemeon(string name, string type)
    {
        this.Name = name;
        this.Type = type;
    }

    public string Name
    {
        get => this.name;
        private set => this.name = value;
    }

    public string Type
    {
        get => this.type;
        private set => this.type = value;
    }
}