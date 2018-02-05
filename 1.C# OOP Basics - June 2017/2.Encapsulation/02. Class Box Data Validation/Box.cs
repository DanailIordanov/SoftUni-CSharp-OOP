using System;

public class Box
{
    private decimal length;
    private decimal width;
    private decimal height;

    public Box(decimal length, decimal width, decimal height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public decimal Length
    {
        get { return this.length; }
        private set
        {
            if (value > 0)
            {
                this.length = value;
            }
            else
            {
                throw new Exception($"{nameof(Length)} cannot be zero or negative.");
            }
        }
    }

    public decimal Width
    {
        get { return this.width; }
        private set
        {
            if (value > 0)
            {
                this.width = value;
            }
            else
            {
                throw new Exception($"{nameof(Width)} cannot be zero or negative.");
            }
        }
    }

    public decimal Height
    {
        get { return this.height; }
        private set
        {
            if (value > 0)
            {
                this.height = value;
            }
            else
            {
                throw new Exception($"{nameof(Height)} cannot be zero or negative.");
            }
        }
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