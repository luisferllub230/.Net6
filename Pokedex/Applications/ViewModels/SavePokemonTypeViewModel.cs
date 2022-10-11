using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.core.Application.ViewModel
{
    public class SavePokemonTypeViewModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "The name of pokemon type is require")]
        public string? typeName { get; set; }

    }
}
