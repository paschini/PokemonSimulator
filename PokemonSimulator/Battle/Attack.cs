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

        public virtual int Use(int level) {
            int damage = BasePower * level;
            UI.ShowMessage($"{Name} träffas med total kraft {damage}! \n");
            return damage;
        }
    }
}
