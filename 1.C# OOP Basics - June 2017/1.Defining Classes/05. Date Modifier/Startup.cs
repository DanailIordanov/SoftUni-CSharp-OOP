using System;
using System.Globalization;

public class Startup
{
    public static void Main()
    {
        var firstDate = DateTime.ParseExact(Console.ReadLine(), "yyyy MM dd", CultureInfo.InvariantCulture);
        var secondDate = DateTime.ParseExact(Console.ReadLine(), "yyyy MM dd", CultureInfo.InvariantCulture);

        var dateModifier = new DateModifier(firstDate, secondDate);
        dateModifier.CalculateDifference();
    }
}
