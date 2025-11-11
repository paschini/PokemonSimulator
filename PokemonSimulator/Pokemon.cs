namespace PokemonSimulator
{
    abstract class Pokemon
    {
        public string Name { get; set; } = "Pokemon";
        public int Level { get; set; }
        public ElementType Type { get; set; }
        public List<Attack> Attacks { get; set; } = [];

        // public Creature(Cell cell, string symbol)
        //{
        //    ArgumentException.ThrowIfNullOrWhiteSpace(symbol);
        //    Cell = cell ?? throw new ArgumentNullException(nameof(cell));
        //    Symbol = symbol;
        //}

        public Pokemon(string name, int level, ElementType type, List<Attack> attacks) 
        {
            if (!string.IsNullOrWhiteSpace(name) && name.Length >= 2 && name.Length <= 15) Name = name;
            else throw new ArgumentException("Name längden måste vara minst 2 och max 15, kan inte vara bara \" \".", nameof(name));

            if (level > 1) Level = level;
            else throw new ArgumentOutOfRangeException(nameof(level), "Level måste vara minst 1.");

            if (attacks.Count > 0) Attacks = attacks;
            else throw new ArgumentException("Attacks kan inte vara null eller tom.", nameof(attacks));

            Type = type;
        }

        public void RandomAttack()
        {
            // Väljer en slumpmässig attack från listan och anropar dess .Use-metod.
        }

        public void Attack() { 
            // Låter användaren välja en attack från listan och anropar dess .Use-metod.
        }

        public void RaiseLevel() { 
            // Ökar nivån på Pokémon och skriver ut att har levlat upp.
        }
    }
}
