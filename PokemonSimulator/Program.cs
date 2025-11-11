namespace PokemonSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pokemon Simulaater");

            Attack flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            Attack ember = new Attack("Ember", ElementType.Fire, 6);
        }
    }
}
