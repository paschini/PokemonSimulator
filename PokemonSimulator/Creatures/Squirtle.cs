using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Squirtle : WaterPokemon, IEvolvable
    {
        public Squirtle(int level, List<Attack> attacks) : base("Squirtle", level, attacks)
        {
        }

        public Squirtle(int level) : base("Squirtle", level, [ElementType.Normal])
        {
        }

        public new Pokemon Evolve()
        {
            Pokemon Evolved = new Wartortle(Level + 10, Attacks); // denna pokemon håller attacker som finns

            UI.EvolveFromTo(Name, Evolved.Name, Evolved.Level, Attacks);

            return Evolved;
        }
    }
}
