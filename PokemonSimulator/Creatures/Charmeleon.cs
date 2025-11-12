using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Charmeleon : FirePokemon
    {
        public Charmeleon(int level, List<Attack> attacks) : base("Charmeleon", level, attacks)
        {
        }

        public Charmeleon(int level) : base("Charmeleon", level, [ElementType.Fire, ElementType.Dragon, ElementType.Normal]) 
        { 
        }
    }
}
