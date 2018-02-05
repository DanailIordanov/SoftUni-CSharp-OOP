using System.Collections.Generic;

public class Trainer
{
    public string Name { get; set; }
    public int NumberOfBadges { get; set; }
    public List<Pokemon> CollectionOfPokemon { get; set; }

    public Trainer(string name, Pokemon pokemon)
    {
        this.NumberOfBadges = 0;
        this.Name = name;
        this.CollectionOfPokemon = new List<Pokemon>();
        this.CollectionOfPokemon.Add(pokemon);
    }
}