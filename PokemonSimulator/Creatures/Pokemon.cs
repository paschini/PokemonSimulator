using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    abstract class Pokemon
    {
        public string Name { get; } = "Pokemon";
        public int Level { get; private set; } = 1;
        public int Health { get; private set; } = 20;
        public ElementType Type { get; }
        protected List<Attack> Attacks { get; } = [];

        public Pokemon(string name, int level, ElementType type, List<Attack> attacks)
        {
            if (!string.IsNullOrWhiteSpace(name) && name.Length >= 2 && name.Length <= 15) Name = name;
            else throw new ArgumentException("Name längden måste vara minst 2 och max 15, kan inte vara bara \" \".", nameof(name));

            if (level >= 1) Level = level;
            else throw new ArgumentOutOfRangeException(nameof(level), "Level måste vara minst 1.");

            if (attacks.Count > 0 && attacks.Count < 5) Attacks = attacks;
            else throw new ArgumentException("Attacks kan inte vara null eller tom och måste vara max 4.", nameof(attacks));

            Type = type;
        }

        public Pokemon(string name, int level, ElementType type, List<ElementType> subtypes)
        {
            if (!string.IsNullOrWhiteSpace(name) && name.Length >= 2 && name.Length <= 15) Name = name;
            else throw new ArgumentException("Name längden måste vara minst 2 och max 15, kan inte vara bara \" \".", nameof(name));

            if (level >= 1) Level = level;
            else throw new ArgumentOutOfRangeException(nameof(level), "Nivå måste vara minst 1.");

            if (subtypes.Count > 0)
            {
                List<Attack> attacks = PokemonBattle.GetPossibleAttacks(level, [type, ..subtypes]);
                Attacks = attacks;

            } else throw new ArgumentException("SubTypes är obligatoriska.", nameof(subtypes));

            Type = type;
        }

        public int RandomAttack()
        {
            // Väljer en slumpmässig attack från listan och anropar dess .Use-metod.
            UI.ShowMessage($"\n{Name} attackerar...");
            var randomAttack = Attacks.OrderBy(_ => new Random().Next()).Take(1).ToArray()[0];
            return randomAttack.Use(Level);
        }

        public int Attack() {
            // Låter användaren välja en attack från listan och anropar dess .Use-metod.
            UI.ShowMessage($"\n{Name} vill attackera...");
            Attack ChosenAttack = UI.ChooseAttack(Attacks);
            return ChosenAttack.Use(Level);
        }

        public void ChangeHealth(int amount)
        {
            Health = amount;
        }

        public virtual Pokemon RaiseLevel() {
            // Ökar nivån på Pokémon och skriver ut att har levlat upp.
            if (Level >= 99) UI.ShowMessage($"{Name} är max nivå och kan inte växa mer.");
            else if (Level + 1 >= 99)
            {
                UI.ShowMessage($"{Name} har växt och är nu max nivå!");
                Level = 99;
            }
            else
            {
                UI.ShowMessage($"{Name} har växt!");
                Level++;
            }

            return this;
        }

        public virtual void Speak()
        {
            UI.ShowMessage("Pruuu pruuu"); // default ljud
        }


        // vi kör internal som en "fusk"...
        // med internal klagar compiler att IEvolvable måste implementera Evolve()
        // och sen klagar det att det gömmar denna Evolve() ... så man MÅSTE implementera på ET RÄTT säät
        internal Pokemon Evolve()
        {
            if (this is IEvolvable evolvable)
            {
                return evolvable.Evolve();
            }
            else
            {
                UI.ShowMessage($"{Name} försöker utveckla men ingentin händer...");
                return this;
            }
        }
    }
}

