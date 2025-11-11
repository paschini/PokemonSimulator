namespace PokemonSimulator
{
    internal interface IEvolvable
    {
        Pokemon EvolvesTo { get; }
        void Evolve();
    }
}