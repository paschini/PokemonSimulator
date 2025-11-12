using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Charizard : FirePokemon
    {
        public Charizard(int level, List<Attack> attacks) : base("Charizard", level, attacks) 
        {
        }

        public Charizard(int level) : base("Charizard", level, [ElementType.Dragon, ElementType.Normal])
        {
        }
    }
}
