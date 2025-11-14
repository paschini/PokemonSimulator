using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Charmander : FirePokemon, IEvolvable
    {
        private int _evolveAtLevel { get; set; } = 20;
        int IEvolvable._evolveAtLevel { get => _evolveAtLevel; set => _evolveAtLevel = value; }

        public Charmander(int level, List<Attack> attacks) : base("Charmander", level, attacks)
        {
        }

        public Charmander(int level) : base("Charmander", level, [ElementType.Normal]) 
        { 
        }

        public override void Speak()
        {
            UI.ShowMessage("Char char? Char char!");
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
            Pokemon Evolved = new Charmeleon(_evolveAtLevel, Attacks); // denna pokemon håller attacker som finns

            UI.EvolveFromTo(Name, Evolved.Name, Evolved.Level, Attacks);

            return Evolved;
        }
    }
}
