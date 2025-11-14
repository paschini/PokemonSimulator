using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    internal class Pikachu : ElectricPokemon, IEvolvable
    {
        private int _evolveAtLevel { get; set; } = 35;
        int IEvolvable._evolveAtLevel { get => _evolveAtLevel; set => _evolveAtLevel = value; }

        public Pikachu(int level, List<Attack> attacks) : base("Pikachu", level, attacks)
        {
        }

        public Pikachu(int level) : base("Pikachu", level, [ElementType.Normal, ElementType.Fairy])
        {
        }

        public override void Speak()
        {
            UI.ShowMessage("Pika piiiiika pikachu?");
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
            Pokemon Evolved = new Raichu(_evolveAtLevel, Attacks); // denna pokemon håller attacker som finns

            UI.EvolveFromTo(Name, Evolved.Name, Evolved.Level, Attacks);

            return Evolved;
        }
    }
}
