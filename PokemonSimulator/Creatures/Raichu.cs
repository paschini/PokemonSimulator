using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal sealed class Raichu : ElectricPokemon
    {
        public Raichu(int level, List<Attack> attacks) : base("Raichu", level, attacks)
        {
        }

        public Raichu(int level) : base("Raichu", level, [ElementType.Normal, ElementType.Fairy])
        {
        }

        public override void Speak()
        {
            UI.ShowMessage("Raichu raichu?");
        }
    }
}
