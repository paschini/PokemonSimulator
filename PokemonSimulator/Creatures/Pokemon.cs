using PokemonSimulator.Battle;
using PokemonSimulator.Simulator;

namespace PokemonSimulator.Creatures
{
    abstract class Pokemon
    {
        public string Name { get; } = "Pokemon";
        public int Level { get; private set; }
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

        public void RandomAttack()
        {
            // Väljer en slumpmässig attack från listan och anropar dess .Use-metod.
            Console.WriteLine($"\n{Name} attackerar...");
            var randomAttack = Attacks.OrderBy(_ => new Random().Next()).Take(1).ToArray()[0];
            randomAttack.Use(Level);
        }

        public void Attack() {
            // Låter användaren välja en attack från listan och anropar dess .Use-metod.
            UI.ShowMessage($"\n{Name} vill attackera...");
            Attack ChosenAttack = UI.ChooseAttack(Attacks);
            ChosenAttack.Use(Level);
        }

        public void RaiseLevel() {
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

        }



        public Pokemon Evolve()
        {
            if (this is IEvolvable evolvable) return evolvable.Evolve();
            else
            {
                UI.ShowMessage($"{Name} försöker utveckla men ingentin händer...");
                return this;
            }
        }
    }
}

