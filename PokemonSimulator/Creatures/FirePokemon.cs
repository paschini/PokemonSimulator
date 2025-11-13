using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal abstract class FirePokemon : Pokemon
    {
        public FirePokemon(string name, int level, List<Attack> attacks) : base(name, level, ElementType.Fire, attacks) 
        {
        }

        public FirePokemon(string name, int level, List<ElementType> subtypes) : base(name, level, ElementType.Fire, subtypes) 
        {
        }
    }
}
