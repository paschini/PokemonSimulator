using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Squirtle : WaterPokemon, IEvolvable
    {
        private int _evolveAtLevel { get; set; } = 10;
        int IEvolvable._evolveAtLevel { get => _evolveAtLevel; set => _evolveAtLevel = value; }

        public Squirtle(int level, List<Attack> attacks) : base("Squirtle", level, attacks)
        {
        }

        public Squirtle(int level) : base("Squirtle", level, [ElementType.Normal])
        {
        }

        public override void Speak()
        {
            UI.ShowMessage("Squiiiiiiiirrrrrtleeeee");
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
            Pokemon Evolved = new Wartortle(_evolveAtLevel, Attacks); // denna pokemon håller attacker som finns

            UI.EvolveFromTo(Name, Evolved.Name, Evolved.Level, Attacks);

            return Evolved;
        }
    }
}
