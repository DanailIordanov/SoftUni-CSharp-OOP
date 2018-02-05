using System;

public class Box
{
    private decimal length;
    private decimal width;
    private decimal height;

    public Box(decimal length, decimal width, decimal height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }
    
    public decimal CalculateSurfaceArea()
    {
        return 2 * this.length * this.width + 2 * this.length * this.height + 2 * this.width * this.height;
    }

    public decimal CalculateLateralSurfacearea()
    {
        return 2 * this.length * this.height + 2 * this.width * this.height;
    }

    public decimal CalculateVolume()
    {
        return this.length * this.height * this.width;
    }
}