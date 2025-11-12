using PokemonSimulator.Battle;
using PokemonSimulator.Creatures;

namespace PokemonSimulator.Simulator
{
    internal class UI
    {
        public static void EvolveFromTo(string From, string To, int newLevel, List<Attack> attacks)
        {
            Console.WriteLine($"\n{From} utvecklas... Nu är en {To} deras nivå är {newLevel}");
            Console.WriteLine("New moveset: \n");

            foreach (Attack attack in attacks)
            {
                Console.WriteLine($"{attack.Name} Type: {attack.Type} Bas Makt: {attack.BasePower}");
            }
            Console.Write("\n");
        }

        public static void PrintAttacks(List<Attack> attacks)
        {
            for (int index = 0; index < attacks.Count; index++)
            {
                Console.WriteLine($"[{index}] {attacks[index].Name} Bas Makt: {attacks[index].BasePower}");
            }
        }

        public static Attack ChooseAttack(List<Attack> availableAttacks)
        {
            Console.WriteLine($"Välj en attack: (mata in attack nummer)");
            PrintAttacks(availableAttacks);

            int chosen;
            while (!int.TryParse(Console.ReadLine(), out chosen) || chosen < 1 || chosen > availableAttacks.Count - 1)
            {
                Console.WriteLine($"Välj en attack: (mata in attack nummer)");
                PrintAttacks(availableAttacks);
                Console.WriteLine("Du måste mata in en nummer från listan som stor mellan []");
            }

            return availableAttacks[chosen];
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
