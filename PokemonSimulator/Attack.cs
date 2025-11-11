namespace PokemonSimulator
{
    internal class Attack
    {
        string Name { get; set; }
        ElementType Type { get; set; }
        int BasePower { get; set; }

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
