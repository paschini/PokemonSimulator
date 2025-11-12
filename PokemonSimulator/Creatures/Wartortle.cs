using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Wartortle : WaterPokemon, IEvolvable
    {
        public Wartortle(int level, List<Attack> attacks) : base("Wartortle", level, attacks)
        {
        }

        public Wartortle(int level) : base("Wartortle", level, [ElementType.Normal])
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
