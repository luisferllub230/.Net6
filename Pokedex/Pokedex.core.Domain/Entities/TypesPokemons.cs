﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.core.Domain.Entities
{
    public class TypesPokemons
    {

        public int id { get; set; }
        public string? typeName { get; set; }

        public ICollection<Pokemons>? pokemons { get; set; }

    }
}
