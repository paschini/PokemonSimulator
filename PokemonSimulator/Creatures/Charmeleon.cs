using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Charmeleon : FirePokemon, IEvolvable
    {
        public Charmeleon(int level, List<Attack> attacks) : base("Charmeleon", level, attacks)
        {
        }

        public Charmeleon(int level) : base("Charmeleon", level, [ElementType.Dragon, ElementType.Normal]) 
        { 
        }

        public new Pokemon Evolve()
        {
            Pokemon Evolved = new Charizard(Level + 40, Attacks); // denna pokemon håller attacker som finns

            UI.EvolveFromTo(Name, Evolved.Name, Evolved.Level, Attacks);

            return Evolved;
        }
    }
}
