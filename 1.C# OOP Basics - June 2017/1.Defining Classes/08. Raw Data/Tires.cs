using System.Collections.Generic;

public class Tires
{
    private double pressure;
    private int age;

    public double Pressure
    {
        get { return this.pressure; }
        set { this.pressure = value; }
    }

    public int Age
    {
        set { this.age = value; }
    }
}