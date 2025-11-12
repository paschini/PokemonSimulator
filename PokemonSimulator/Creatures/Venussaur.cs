using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Venussaur : GrassPokemon
    {
        public Venussaur(int level, List<Attack> attacks) : base("Venussaur", level, attacks)
        {
        }

        public Venussaur(int level) : base("Venussaur", level, [ElementType.Normal])
        {
        }
    }
}
