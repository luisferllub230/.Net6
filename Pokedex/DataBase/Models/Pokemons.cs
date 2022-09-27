using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class Pokemons
    {
        public int id { get; set; }
        public string pokemonName { get; set; }
        public string pokemonImg { get; set; }

        public int pokemonRegionId { get; set; }
        public PokemonRegions pokemonRegions { get; set; }

        public int TypePrimaryPokemonId { get; set; }
        public TypesPokemons typesPrimaryPokemons { get; set; }

        public int TypeSecondaryPokemonId { get; set; }

    }
}
