using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Pikachu : ElectricPokemon
    {
        public Pikachu(int level, List<Attack> attacks) : base("Pikachu", level, attacks)
        {
        }

        public Pikachu(int level) : base("Pikachu", level, [ElementType.Normal, ElementType.Fairy])
        {
        }
    }
}
