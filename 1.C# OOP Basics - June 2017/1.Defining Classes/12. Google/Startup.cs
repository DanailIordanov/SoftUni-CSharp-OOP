using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var people = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var inputParams = input.Split();
            var personName = inputParams[0];
            
            if (!people.Any(p => p.Name == personName))
            {
                people.Add(new Person(personName));
            }

            var person = people.Single(p => p.Name == personName);

            switch (inputParams[1])
            {
                case "company":
                    var companyName = inputParams[2];
                    var department = inputParams[3];
                    var salary = decimal.Parse(inputParams[4]);

                    var company = new Company(companyName, department, salary);
                    person.Company = company;
                    break;

                case "pokemon":
                    var pokemonName = inputParams[2];
                    var pokemonType = inputParams[3];

                    var pokemon = new Pokemeon(pokemonName, pokemonType);
                    person.Pokemeons.Add(pokemon);
                    break;

                case "parents":
                    var parentName = inputParams[2];
                    var parentBirthday = inputParams[3];

                    var parent = new Parent(parentName, parentBirthday);
                    person.Parents.Add(parent);
                    break;

                case "children":
                    var childName = inputParams[2];
                    var childBirthday = inputParams[3];

                    var child = new Child(childName, childBirthday);
                    person.Children.Add(child);
                    break;

                case "car":
                    var carModel = inputParams[2];
                    var carSpeed = int.Parse(inputParams[3]);

                    var car = new Car(carModel, carSpeed);
                    person.Car = car;
                    break;
            }
        }

        var finalPersonName = Console.ReadLine();
        Console.WriteLine(people.Single(p => p.Name == finalPersonName).ToString());
    }
}