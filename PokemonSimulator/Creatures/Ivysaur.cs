using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Ivysaur : GrassPokemon, IEvolvable
    {
        private int _evolveAtLevel { get; set; } = 12;
        int IEvolvable._evolveAtLevel { get => _evolveAtLevel; set => _evolveAtLevel = value; }

        public Ivysaur(int level, List<Attack> attacks) : base("Ivysaur", level, attacks)
        {
        }

        public Ivysaur(int level) : base("Ivysaur", level, [ElementType.Normal])
        {
        }

        public override void Speak()
        {
            UI.ShowMessage("Ivyyy ivisaaaaur!");
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
            Pokemon Evolved = new Venussaur(_evolveAtLevel, Attacks); // denna pokemon håller attacker som finns

            UI.EvolveFromTo(Name, Evolved.Name, Evolved.Level, Attacks);

            return Evolved;
        }
    }
}
