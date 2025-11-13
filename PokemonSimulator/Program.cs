using PokemonSimulator.Creatures;

namespace PokemonSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pokemon Simulator");

            Console.WriteLine("\nVi kör Steve... Steve är en Charmander!");
            Pokemon Steve = new Charmander(7);
            //Steve.Attacks[1].Use(2); // protected, funkar inte :) bara en demo...
            Steve = Steve.Evolve(); // Till Charmeleon
            Steve = Steve.Evolve(); // Till Charizard

            // konfirmation
            Console.WriteLine(Steve.Name);
            Console.WriteLine(Steve.GetType());

            Console.WriteLine("\nVi kör alla pokemon i beltet...");
            List<Pokemon> Belt = new() {
                    new Pikachu(1), // kan inte utveckla
                    new Squirtle(5), 
                    new Bulbasaur(2),
                    new Charmander(3)
            };
            
            // TODO: vänta på läraren


            for (var i = 0; i < Belt.Count; i++)
            {
                Belt[i].RandomAttack();
                Belt[i].Attack();
                Belt[i].RaiseLevel();
                Belt[i] = Belt[i].Evolve();
            }
        }
    }
}
