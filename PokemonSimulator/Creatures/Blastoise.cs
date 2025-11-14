using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal sealed class Blastoise : WaterPokemon, IEvolvable
    {
        private int _evolveAtLevel { get; set; } = 50;
        int IEvolvable._evolveAtLevel { get => _evolveAtLevel; set => _evolveAtLevel = value; }

        public Blastoise(int level, List<Attack> attacks) : base("Blastoise", level, attacks)
        {
        }

        public Blastoise(int level) : base("Blastoise", level, [ElementType.Normal])
        {
        }

        public override void Speak()
        {
            UI.ShowMessage("Blasssstoooooooise!!");
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
            Pokemon Evolved = new Blastoise(_evolveAtLevel, Attacks); // denna pokemon håller attacker som finns

            UI.EvolveFromTo(Name, Evolved.Name, Evolved.Level, Attacks);

            return Evolved;
        }
    }
}
