using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class PokemonRegions
    {
        public int id { get; set; }
        public string pokemonRegionsName { get; set; }
        
        //navigation property
        public ICollection<Pokemons> pokemons { get; set; }
    }
}
