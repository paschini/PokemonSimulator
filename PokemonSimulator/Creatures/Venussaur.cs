using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal sealed class Venussaur : GrassPokemon
    {
        public Venussaur(int level, List<Attack> attacks) : base("Venussaur", level, attacks)
        {
        }

        public Venussaur(int level) : base("Venussaur", level, [ElementType.Normal])
        {
        }

        public override void Speak()
        {
            UI.ShowMessage("Veeenuuuusaaaaaaauuuuur!!");
        }
    }
}
