using System;
using System.Text;

public abstract class Harvester
{
    private string id;
    private double oreOutput;
    private double energyRequirement;

    public Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    protected string Id => this.id;

    public double OreOutput
    {
        get
        {
            return this.oreOutput;
        }
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(this.OreOutput)}");
            }
            this.oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get
        {
            return this.energyRequirement;
        }
        protected set
        {
            if (value <= 0 || value > 20000)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(this.EnergyRequirement)}");
            }
            this.energyRequirement = value;
        }
    }

    public double ModeOreOutput(string mode)
    {
        if (mode == "Full")
        {
            return this.OreOutput;
        }
        else if (mode == "Half")
        {
            return this.OreOutput * 0.5;
        }
        else
        {
            return 0;
        }
    }

    public double ModeEnergyRequirement(string mode)
    {
        if (mode == "Full")
        {
            return this.EnergyRequirement;
        }
        else if (mode == "Half")
        {
            return this.EnergyRequirement * 0.6;
        }
        else
        {
            return 0;
        }
    }
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Ore Output: {this.OreOutput}");
        sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");
        return sb.ToString();
    }
}