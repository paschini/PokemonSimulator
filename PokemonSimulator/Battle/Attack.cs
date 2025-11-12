using PokemonSimulator.Simulator;

namespace PokemonSimulator.Battle
{
    internal class Attack
    {
        public string Name { get; set; }
        public ElementType Type { get; set; }
        public int BasePower { get; set; }

        public Attack(string name, ElementType type, int basePower)
        {
            Name = name;
            Type = type;
            BasePower = basePower;
        }

        public void Use(int level) { 
            Console.WriteLine($"{Name} hit with a total power of {BasePower + level}!");
        }
    }
}
