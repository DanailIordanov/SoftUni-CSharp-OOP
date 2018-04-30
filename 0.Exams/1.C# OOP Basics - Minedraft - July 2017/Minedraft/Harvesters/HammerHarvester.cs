using System.Text;

public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement) : base(id, oreOutput, energyRequirement)
    {
        base.OreOutput += oreOutput * 2;
        base.EnergyRequirement += energyRequirement;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Hammer Harvester - {base.Id}");
        sb.Append(base.ToString());
        return sb.ToString();
    }
}