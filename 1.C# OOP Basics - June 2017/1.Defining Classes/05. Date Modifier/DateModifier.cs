using System;

public class DateModifier
{
    private DateTime firstDate;
    private DateTime secondDate;

    public DateModifier(DateTime firstDate, DateTime secondDate)
    {
        this.firstDate = firstDate;
        this.secondDate = secondDate;
    }

    public void CalculateDifference()
    {
        int difference = Math.Abs((this.firstDate - this.secondDate).Days);
        Console.WriteLine(difference);
    }
}
