using PokemonSimulator.Simulator;

namespace PokemonSimulator.Battle
{
    internal class LegendaryAttack : Attack
    {
        public LegendaryAttack(Attack baseAttack) : base($"{baseAttack.Name} EX", baseAttack.Type, baseAttack.BasePower)
        {
        }

        public override int Use(int level)
        {
            int damage = BasePower + level * 2;
            UI.ShowMessage($"Legendarisk attack {Name} träffas med total kraft {damage}! \n");
            return damage;
        }
    }
}
