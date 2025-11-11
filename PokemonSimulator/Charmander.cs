namespace PokemonSimulator
{
    internal class Charmander : FirePokemon, IEvolvable
    {
        public Charmander(int level, List<Attack> attacks) : base("Charmander", level, attacks)
        {
        }

        private Pokemon _evolvesTo { get; } = new Charmeleon(11, new List<Attack>
        {
            new Attack("Flamethrower", ElementType.Fire, 20),
            new Attack("Dragon Claw", ElementType.Dragon, 20)
        });

        public Pokemon EvolvesTo => _evolvesTo;

        public void Evolve()
        {
            Console.WriteLine($"{Name} is evolving... Now it is a {EvolvesTo.Name} and its level is {EvolvesTo.Level}");
        }
    }
}
