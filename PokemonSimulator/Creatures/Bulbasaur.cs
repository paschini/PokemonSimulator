using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Bulbasaur : GrassPokemon, IEvolvable
    {
        public Bulbasaur(int level, List<Attack> attacks) : base("Bulbasaur", level, attacks)
        {
        }

        public Bulbasaur(int level) : base("Bulbasaur", level, [ElementType.Normal])
        {
        }

        public new Pokemon Evolve()
        {
            Pokemon Evolved = new Ivysaur(Level + 10, Attacks); // denna pokemon håller attacker som finns

            UI.EvolveFromTo(Name, Evolved.Name, Evolved.Level, Attacks);

            return Evolved;
        }
    }
}
