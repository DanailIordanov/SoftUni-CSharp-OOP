using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var input = Console.ReadLine().Split().ToArray();
        var n = long.Parse(input[0]);
        var m = long.Parse(input[1]);
        var rectangles = new Dictionary<string, Rectangle>();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split().ToArray();
            var currentRectangle = new Rectangle(line[0], long.Parse(line[1]), long.Parse(line[2]), long.Parse(line[3]), long.Parse(line[4]));

            rectangles[currentRectangle.ID] = currentRectangle;
        }

        for (int i = 0; i < m; i++)
        {
            var command = Console.ReadLine().Split().ToArray();
            var firstId = command[0];
            var secondId = command[1];

            if (rectangles[firstId].Intersects(rectangles[secondId]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
