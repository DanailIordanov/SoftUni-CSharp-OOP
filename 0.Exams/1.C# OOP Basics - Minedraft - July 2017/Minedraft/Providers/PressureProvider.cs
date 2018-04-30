using System.Text;

public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput) : base(id, energyOutput)
    {
        base.EnergyOutput += energyOutput * 0.5;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Pressure Provider - {this.Id}");
        sb.Append(base.ToString());
        return sb.ToString();
    }
}