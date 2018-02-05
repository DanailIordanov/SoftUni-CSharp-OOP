using System;

public class Rectangle
{
    public string ID { get; set; }
    private long height;
    private long width;
    private long topLeftX;
    private long topLeftY;

    public Rectangle(string id, long height, long width, long topLeftX, long topLeftY)
    {
        this.ID = id;
        this.height = height;
        this.width = width;
        this.topLeftX = topLeftX;
        this.topLeftY = topLeftY;
    }

    public bool Intersects(Rectangle rectangle)
    {
        var firstRectX1 = Math.Min(rectangle.topLeftX, rectangle.topLeftX + rectangle.height);
        var firstRectX2 = Math.Max(rectangle.topLeftX, rectangle.topLeftX + rectangle.height);
        var firstRectY1 = Math.Min(rectangle.topLeftY, rectangle.topLeftY + rectangle.width);
        var firstRectY2 = Math.Max(rectangle.topLeftY, rectangle.topLeftY + rectangle.width);

        var secondRectX1 = Math.Min(this.topLeftX, this.topLeftX + this.height);
        var secondRectX2 = Math.Max(this.topLeftX, this.topLeftX + this.height);
        var secondRectY1 = Math.Min(this.topLeftY, this.topLeftY + this.width);
        var secondRectY2 = Math.Max(this.topLeftY, this.topLeftY + this.width);

        if ((secondRectX2 >= firstRectX1 && secondRectX1 <= firstRectX2) && (secondRectY2 >= firstRectY1 && secondRectY1 <= firstRectY2))
        {
            return true;
        }
        return false;
    }
}
