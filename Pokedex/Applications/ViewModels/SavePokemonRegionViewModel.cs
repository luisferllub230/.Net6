using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.core.Application.ViewModel
{
    public class SavePokemonRegionViewModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "The name of pokemon region is require")]
        public string? pokemonRegionsName { get; set; }
    }
}
