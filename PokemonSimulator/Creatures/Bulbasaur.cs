using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Bulbasaur : GrassPokemon, IEvolvable
    {
        private int _evolveAtLevel { get; set; } = 15;
        int IEvolvable._evolveAtLevel { get => _evolveAtLevel; set => _evolveAtLevel = value; }

        public Bulbasaur(int level, List<Attack> attacks) : base("Bulbasaur", level, attacks)
        {
        }

        public Bulbasaur(int level) : base("Bulbasaur", level, [ElementType.Normal])
        {
        }

        public override void Speak()
        {
            UI.ShowMessage("Bulbaaa?");
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
            Pokemon Evolved = new Ivysaur(_evolveAtLevel, Attacks); // denna pokemon håller attacker som finns

            UI.EvolveFromTo(Name, Evolved.Name, Evolved.Level, Attacks);

            return Evolved;
        }
    }
}
