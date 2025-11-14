using PokemonSimulator.Creatures;

namespace PokemonSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pokemon Simulator");

            Console.WriteLine("\nVi kör alla pokemon i beltet...");
            List<Pokemon> Belt = new() 
            {
                    new Pikachu(34), 
                    new Squirtle(9), 
                    new Bulbasaur(14),
                    new Charmander(19)
            };


            for (var i = 0; i < Belt.Count; i++)
            {
                Belt[i].Speak();
                Belt[i].RandomAttack();
                Belt[i].Attack();
                Belt[i] = Belt[i].RaiseLevel();
                Belt[i].Speak();
            }
        }
    }
}
