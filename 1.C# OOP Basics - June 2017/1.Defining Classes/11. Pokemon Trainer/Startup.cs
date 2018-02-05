using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var dictionaryOfTrainers = new Dictionary<string, Trainer>();
        var line = Console.ReadLine().Split().ToArray();
        
        while (line[0] != "Tournament")
        {
            var currentPokemon = new Pokemon(line[1], line[2], int.Parse(line[3]));

            if (!dictionaryOfTrainers.ContainsKey(line[0]))
            {
                var currentTrainer = new Trainer(line[0], currentPokemon);
                dictionaryOfTrainers[line[0]] = currentTrainer;
            }
            else
            {
                dictionaryOfTrainers[line[0]].CollectionOfPokemon.Add(currentPokemon);
            }

            line = Console.ReadLine().Split().ToArray();
        }

        var command = Console.ReadLine();

        while (command != "End")
        {
            foreach (var trainer in dictionaryOfTrainers)
            {
                if (trainer.Value.CollectionOfPokemon.Any(p => p.Element == command))
                {
                    trainer.Value.NumberOfBadges++;
                }
                else
                {
                    trainer.Value.CollectionOfPokemon.ForEach(p => p.Health -= 10);
                    for (int i = 0; i < trainer.Value.CollectionOfPokemon.Count; i++)
                    {
                        if (trainer.Value.CollectionOfPokemon.Any(p => p.Health <= 0))
                        {
                            var pokemon = trainer.Value.CollectionOfPokemon.Where(p => p.Health <= 0).FirstOrDefault();
                            trainer.Value.CollectionOfPokemon.Remove(pokemon);
                        }
                    }
                }
            }
            command = Console.ReadLine();
        }

        foreach (var trainer in dictionaryOfTrainers.OrderByDescending(t => t.Value.NumberOfBadges))
        {
            Console.WriteLine($"{trainer.Value.Name} {trainer.Value.NumberOfBadges} {trainer.Value.CollectionOfPokemon.Count}");
        }
    }
}