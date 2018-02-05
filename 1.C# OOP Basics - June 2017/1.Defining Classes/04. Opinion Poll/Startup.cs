using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var listOfPeople = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split().ToArray();
            var currentPerson = new Person(tokens[0], int.Parse(tokens[1]));

            if (currentPerson.Age > 30)
            {
                listOfPeople.Add(currentPerson);
            }
        }

        foreach (var person in listOfPeople.OrderBy(p => p.Name))
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}
