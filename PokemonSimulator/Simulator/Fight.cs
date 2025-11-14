using PokemonSimulator.Creatures;
using System.ComponentModel.DataAnnotations;

namespace PokemonSimulator.Simulator
{
    internal class Fight
    {
        internal required Pokemon LeftOpponent { get; set; }
        internal required Pokemon RightOpponent { get; set; }

        public Pokemon? AutoFight () {
            Pokemon? winner = LeftOpponent;
            
            while (LeftOpponent.Health > 0 || RightOpponent.Health > 0)
            {
                RightOpponent.ChangeHealth(RightOpponent.Health - LeftOpponent.RandomAttack());
                LeftOpponent.ChangeHealth(LeftOpponent.Health - RightOpponent.RandomAttack());

                winner = LeftOpponent.Health != RightOpponent.Health ? LeftOpponent.Health > RightOpponent.Health ? LeftOpponent : RightOpponent : null;

            }

            return winner; 
        }
    }
}
