using PokemonSimulator.Battle;
using PokemonSimulator.Creatures;
using PokemonSimulator.Simulator;

namespace PokemonSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pokemon Simulator");

            Attack flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            Attack ember = new Attack("Ember", ElementType.Fire, 6);

            Charmander Edgar = new Charmander(1, [flamethrower, ember]);
            Edgar.Evolve();

            Charmander Steve = new Charmander(7);
            Steve.Evolve();
        }
    }
}
