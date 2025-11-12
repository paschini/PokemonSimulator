using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Charmander : FirePokemon, IEvolvable
    {
        public Charmander(int level, List<Attack> attacks) : base("Charmander", level, attacks)
        {
        }

        public Charmander(int level) : base("Charmander", level, [ElementType.Normal]) 
        { 
        }

        public new Pokemon Evolve()
        {
            Pokemon Evolved = new Charmeleon(Level + 10, Attacks); // denna pokemon håller attacker som finns

            UI.EvolveFromTo(Name, Evolved.Name, Evolved.Level, Attacks);

            return Evolved;
        }
    }
}
