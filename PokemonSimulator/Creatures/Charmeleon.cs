using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Charmeleon : FirePokemon, IEvolvable
    {
        private int _evolveAtLevel { get; set; } = 50;
        int IEvolvable._evolveAtLevel { get => _evolveAtLevel; set => _evolveAtLevel = value; }

        public Charmeleon(int level, List<Attack> attacks) : base("Charmeleon", level, attacks)
        {
        }

        public Charmeleon(int level) : base("Charmeleon", level, [ElementType.Dragon, ElementType.Normal]) 
        { 
        }

        public override void Speak()
        {
            UI.ShowMessage("Chaaaaaarrr ...");
        }

        public override Pokemon RaiseLevel()
        {
            base.RaiseLevel();

            if (Level >= _evolveAtLevel)
            {
                return Evolve();
            }

            return this;
        }

        public new Pokemon Evolve()
        {
            Pokemon Evolved = new Charizard(_evolveAtLevel, Attacks); // denna pokemon håller attacker som finns

            UI.EvolveFromTo(Name, Evolved.Name, Evolved.Level, Attacks);

            return Evolved;
        }
    }
}
