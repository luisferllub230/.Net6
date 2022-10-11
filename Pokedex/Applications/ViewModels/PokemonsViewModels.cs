using Pokedex.core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.core.Application.ViewModel
{
    public class PokemonsViewModels
    {
        public int id { get; set; }
        public string? pokemonName { get; set; }
        public string? pokemonImg { get; set; }

        public PokemonRegions? pokemonRegions { get; set; }
        public TypesPokemons? typesPrimaryPokemons { get; set; }

        public int TypeSecondaryPokemonId { get; set; }
        public TypesPokemons? typesSecondaryPokemons { get; set; }// I don't know why it does not work  


    }
}
