using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal abstract class GrassPokemon : Pokemon
    {
        public GrassPokemon(string name, int level, List<Attack> attacks) : base(name, level, ElementType.Grass, attacks)
        {
        }

        public GrassPokemon(string name, int level, List<ElementType> subtypes) : base(name, level, ElementType.Grass, subtypes)
        {
        }
    }
}
