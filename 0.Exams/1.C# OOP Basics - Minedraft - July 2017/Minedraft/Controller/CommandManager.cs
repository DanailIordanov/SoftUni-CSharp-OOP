using System;
using System.Collections.Generic;
using System.Linq;

public class CommandManager
{
    private DraftManager draftManager;

    public CommandManager()
    {
        this.draftManager = new DraftManager();
    }

    public void ReadCommands()
    {
        var command = Console.ReadLine();

        while (command != "Shutdown")
        {
            this.ExecuteCommand(command);
            command = Console.ReadLine();
        }

        Console.WriteLine(draftManager.ShutDown());
    }

    private void ExecuteCommand(string command)
    {
        var cmdArgs = command.Split();
        string message = null;

        switch (cmdArgs[0])
        {
            case "RegisterHarvester":
                message = draftManager.RegisterHarvester(cmdArgs.Skip(1).ToList());
                Console.WriteLine(message);
                break;
            case "RegisterProvider":
                message = draftManager.RegisterProvider(cmdArgs.Skip(1).ToList());
                Console.WriteLine(message);
                break;
            case "Day":
                message = draftManager.Day();
                Console.WriteLine(message);
                break;
            case "Mode":
                message = draftManager.Mode(cmdArgs.Skip(1).ToList());
                Console.WriteLine(message);
                break;
            case "Check":
                message = draftManager.Check(cmdArgs.Skip(1).ToList());
                Console.Write(message);
                break;
        }
    }
}