using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class WaterPokemon : Pokemon
    {
        public WaterPokemon(string name, int level, List<Attack> attacks) : base(name, level, ElementType.Water, attacks)
        {
        }

        public WaterPokemon(string name, int level, List<ElementType> subtypes) : base(name, level, ElementType.Water, subtypes)
        {
        }
    }
}
