using System;
using System.Linq;
using System.Reflection;

public class Startup
{
    public static void Main()
    {
        Type boxType = typeof(Box);
        FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine(fields.Count());

        var length = decimal.Parse(Console.ReadLine());
        var width = decimal.Parse(Console.ReadLine());
        var height = decimal.Parse(Console.ReadLine());

        var box = new Box(length, width, height);

        Console.WriteLine($"Surface Area - {box.CalculateSurfaceArea():f2}");
        Console.WriteLine($"Lateral Surface Area - {box.CalculateLateralSurfacearea():f2}");
        Console.WriteLine($"Volume - {box.CalculateVolume():f2}");
    }
}