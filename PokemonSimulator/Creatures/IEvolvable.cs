namespace PokemonSimulator.Creatures
{
    internal interface IEvolvable
    {
        int _evolveAtLevel { get; set; }
        Pokemon Evolve();
    }
}