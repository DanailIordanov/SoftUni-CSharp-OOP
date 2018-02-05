public class Cargo
{
    private int weight;
    private string type;

    public int Weight
    {
        set { this.weight = value; }
    }
    public string Type
    {
        get { return this.type; }
        set { this.type = value; }
    }
}