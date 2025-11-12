using PokemonSimulator.Battle;

namespace PokemonSimulator.Simulator
{
    internal class PokemonBattle
    {
        public static readonly Dictionary<int, List<Attack>> AttacksByLevel = new()
        {
            { 1, new() {
                    new Attack("Scratch", ElementType.Normal, 10),
                    new Attack("Tackle", ElementType.Normal, 10),
                    new Attack("Bubble", ElementType.Water, 12),
                    new Attack("Ember", ElementType.Fire, 15),
                    new Attack("Vine Whip", ElementType.Grass, 12)
                }
            },
            { 5, new() { 
                    new Attack("Fire Lash", ElementType.Fire, 15),
                    new Attack("Aqua Jet", ElementType.Water, 15),
                    new Attack("Leaf Blade", ElementType.Grass, 15),
                } 
            },
            { 10, new() { 
                    new Attack("Smokescreen", ElementType.Normal, 5),
                    new Attack("Water Pulse", ElementType.Water, 20),
                    new Attack("Razor Leaf", ElementType.Grass, 18),
                    new Attack("Flamethrower", ElementType.Fire, 20)
                } 
            },
            { 15, new() { 
                    new Attack("Flame Burst", ElementType.Fire, 25),
                    new Attack("Hydro Pump", ElementType.Water, 30),
                    new Attack("Solar Beam", ElementType.Grass, 30),
                } 
            }
        };

        public static List<Attack> GetPossibleAttacks(int pokemonLevel, List<ElementType> preferredTypes)
        {
            var possibleAttacks = new List<Attack>();

            var rng = new Random();
            var possibleMoves = AttacksByLevel
                .Where(m => m.Key <= pokemonLevel)
                .SelectMany(m => m.Value)
                .Where(a => preferredTypes.Contains(a.Type))
                .ToList();

            return possibleMoves.OrderBy(_ => rng.Next()).Take(4).ToList();
        }
    }
}
