using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Ivysaur : GrassPokemon, IEvolvable
    {
        public Ivysaur(int level, List<Attack> attacks) : base("Ivysaur", level, attacks)
        {
        }

        public Ivysaur(int level) : base("Ivysaur", level, [ElementType.Normal])
        {
        }

        public new Pokemon Evolve()
        {
            Pokemon Evolved = new Venussaur(Level + 10, Attacks); // denna pokemon håller attacker som finns

            UI.EvolveFromTo(Name, Evolved.Name, Evolved.Level, Attacks);

            return Evolved;
        }
    }
}
