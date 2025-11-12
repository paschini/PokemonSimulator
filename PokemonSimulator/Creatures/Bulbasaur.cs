using PokemonSimulator.Battle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.Creatures
{
    internal class Bulbasaur : GrassPokemon
    {
        public Bulbasaur(int level, List<Attack> attacks) : base("Bulbasaur", level, attacks)
        {
        }
    }
}
