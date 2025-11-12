using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;
namespace PokemonSimulator.Creatures
{
    internal class Charmander : FirePokemon, IEvolvable
    {
        public Charmander(int level, List<Attack> attacks) : base("Charmander", level, attacks)
        {
        }

        public Charmander(int level) : base("Charmander", level, [ElementType.Fire, ElementType.Normal]) 
        { 
        }

        public void Evolve()
        {
            Pokemon Evolved = new Charmeleon(11);

            Console.WriteLine($"{Name} is evolving... Now it is a {Evolved.Name} and its level is {Evolved.Level}");
            Console.WriteLine("New moveset: \n");

            foreach (Attack attack in Evolved.Attacks) 
            {
                Console.WriteLine($"{attack.Name} Type: {attack.Type} Base Power: {attack.BasePower}");
            }
        }
    }
}
