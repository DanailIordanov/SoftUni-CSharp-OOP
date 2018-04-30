using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private Dictionary<string, Harvester> harvesterCollection;
    private Dictionary<string, Provider> providerCollection;
    private double totalEnergyStored;
    private double totalMinedOre;
    private string currentMode;

    public DraftManager()
    {
        this.harvesterCollection = new Dictionary<string, Harvester>();
        this.providerCollection = new Dictionary<string, Provider>();
        this.totalEnergyStored = 0.0;
        this.totalMinedOre = 0.0;
        this.currentMode = "Full";
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            var type = arguments[0];
            var id = arguments[1];
            var oreOutput = double.Parse(arguments[2]);
            var energyRequirement = double.Parse(arguments[3]);
            if (type == "Sonic")
            {
                var sonicFactor = int.Parse(arguments[4]);
                harvesterCollection[id] = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
            }
            else
            {
                harvesterCollection[id] = new HammerHarvester(id, oreOutput, energyRequirement);
            }

            return $"Successfully registered {type} Harvester - {id}";
        }
        catch (ArgumentException ae)
        {
            return ae.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            var type = arguments[0];
            var id = arguments[1];
            var energyOutput = double.Parse(arguments[2]);
            if (type == "Solar")
            {
                providerCollection[id] = new SolarProvider(id, energyOutput);
            }
            else
            {
                providerCollection[id] = new PressureProvider(id, energyOutput);
            }
            return $"Successfully registered {type} Provider - {id}";
        }
        catch (ArgumentException ae)
        {
            return ae.Message;
        }
    }

    public string Day()
    {
        var summedEnergyRequirement = 0.0;
        var summedEnergyOutput = 0.0;
        var summedOreOutput = 0.0;

        if (providerCollection.Any())
        {
            foreach (var provider in providerCollection)
            {
                summedEnergyOutput += provider.Value.EnergyOutput;
                totalEnergyStored += provider.Value.EnergyOutput;
            }
        }
        
        if (harvesterCollection.Any())
        {
            foreach (var harvester in harvesterCollection)
            {
                summedEnergyRequirement += harvester.Value.ModeEnergyRequirement(currentMode);
                summedOreOutput += harvester.Value.ModeOreOutput(currentMode);
            }
        }

        if (totalEnergyStored >= summedEnergyRequirement)
        {
            totalMinedOre += summedOreOutput;
            totalEnergyStored -= summedEnergyRequirement;
        }
        else
        {
            summedOreOutput = 0;
        }

        var result = new StringBuilder();
        result.AppendLine("A day has passed.");
        result.AppendLine($"Energy Provided: {summedEnergyOutput}");
        result.Append($"Plumbus Ore Mined: {summedOreOutput}");
        return result.ToString();
    }

    public string Mode(List<string> arguments)
    {
        var mode = arguments[0];
        this.currentMode = mode;
        return $"Successfully changed working mode to {mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[0];

        if (providerCollection.ContainsKey(id))
        {
            return providerCollection[id].ToString();
        }
        else if (harvesterCollection.ContainsKey(id))
        {
            return harvesterCollection[id].ToString();
        }

        return $"No element found with id - {id}" + Environment.NewLine;
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.totalEnergyStored}");
        sb.Append($"Total Mined Plumbus Ore: {this.totalMinedOre}");
        return sb.ToString();
    }
}