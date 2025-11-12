using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class ElectricPokemon : Pokemon
    {
        public ElectricPokemon(string name, int level, List<Attack> attacks) : base(name, level, ElementType.Electric, attacks)
        {
        }

        public ElectricPokemon(string name, int level, List<ElementType> subtypes) : base(name, level, ElementType.Electric, subtypes)
        {
        }
    }
}
