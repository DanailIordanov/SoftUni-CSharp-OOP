using System;

public class CommandManager
{
    private CarManager carManager;

    public CommandManager()
    {
        this.carManager = new CarManager();
    }

    public void Execute()
    {
        var command = Console.ReadLine();

        while (command != "Cops Are Here")
        {
            ReadCommand(command);
            command = Console.ReadLine();
        }
    }

    public void ReadCommand(string command)
    {
        var cmdArgs = command.Split();
        switch (cmdArgs[0].ToLower())
        {
            case "register":
                carManager.Register(int.Parse(cmdArgs[1]), cmdArgs[2], cmdArgs[3], cmdArgs[4], int.Parse(cmdArgs[5]),
                    int.Parse(cmdArgs[6]), int.Parse(cmdArgs[7]), int.Parse(cmdArgs[8]), int.Parse(cmdArgs[9]));
                break;
            case "check":
                Console.Write(carManager.Check(int.Parse(cmdArgs[1])));
                break;
            case "open":
                carManager.Open(int.Parse(cmdArgs[1]), cmdArgs[2], int.Parse(cmdArgs[3]), cmdArgs[4], int.Parse(cmdArgs[5]));
                break;
            case "participate":
                carManager.Participate(int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                break;
            case "start":
                Console.Write(carManager.Start(int.Parse(cmdArgs[1])));
                break;
            case "park":
                carManager.Park(int.Parse(cmdArgs[1]));
                break;
            case "unpark":
                carManager.Unpark(int.Parse(cmdArgs[1]));
                break;
            case "tune":
                carManager.Tune(int.Parse(cmdArgs[1]), cmdArgs[2]);
                break;
        }
    }
}