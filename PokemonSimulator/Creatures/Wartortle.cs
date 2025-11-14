using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Wartortle : WaterPokemon, IEvolvable
    {
        private int _evolveAtLevel { get; set; } = 16;
        int IEvolvable._evolveAtLevel { get => _evolveAtLevel; set => _evolveAtLevel = value; }

        public Wartortle(int level, List<Attack> attacks) : base("Wartortle", level, attacks)
        {
        }

        public Wartortle(int level) : base("Wartortle", level, [ElementType.Normal])
        {
        }

        public override void Speak()
        {
            UI.ShowMessage("Waaaarr torrrrrtle");
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
