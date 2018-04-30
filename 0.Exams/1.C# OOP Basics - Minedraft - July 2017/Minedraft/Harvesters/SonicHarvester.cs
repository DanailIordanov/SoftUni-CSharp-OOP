using System.Text;

public class SonicHarvester : Harvester
{
    private int sonicFactor;

    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) : base(id, oreOutput, energyRequirement)
    {
        this.sonicFactor = sonicFactor;
        base.EnergyRequirement = energyRequirement / sonicFactor;
    }

    //public int SonicFactor
    //{
    //    get { return this.sonicFactor; }
    //    set { this.SonicFactor = sonicFactor; }
    //}

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Sonic Harvester - {base.Id}");
        sb.Append(base.ToString());
        return sb.ToString();
    }
}