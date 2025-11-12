using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Blastoise : WaterPokemon, IEvolvable
    {
        public Blastoise(int level, List<Attack> attacks) : base("Blastoise", level, attacks)
        {
        }

        public Blastoise(int level) : base("Blastoise", level, [ElementType.Normal])
        {
        }

        public new Pokemon Evolve()
        {
            Pokemon Evolved = new Blastoise(Level + 10, Attacks); // denna pokemon håller attacker som finns

            UI.EvolveFromTo(Name, Evolved.Name, Evolved.Level, Attacks);

            return Evolved;
        }
    }
}
