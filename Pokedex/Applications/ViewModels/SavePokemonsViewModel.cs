using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.core.Application.ViewModel
{
    public class SavePokemonsViewModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "The name of pokemon is require")]
        public string? pokemonName { get; set; }
        [Required(ErrorMessage = "The url img of pokemon is require")]
        public string? pokemonImg { get; set; }
        [Required(ErrorMessage = "The Region of pokemon is require")]
        public int pokemonRegionId { get; set; }
        [Required(ErrorMessage = "The Type primary of pokemon is require")]
        public int TypePrimaryPokemonId { get; set; }
        [Required(ErrorMessage = "The Type secondary of pokemon is require")]
        public int TypeSecondaryPokemonId { get; set; }
    }
}
