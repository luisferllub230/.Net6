using Pokedex.core.Application.Interfaces.Repositories;
using Pokedex.core.Application.Interfaces.Services;
using Pokedex.core.Application.ViewModel;
using Pokedex.core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.core.Application.Services
{
    public class PokemonServices : IPokemonServices
    {
        private readonly IPokemonRepository _pr;

        public PokemonServices(IPokemonRepository Pokemon) 
        {
            _pr = Pokemon;
        }

        
        public async Task Add(SavePokemonsViewModel spvm) 
        {
            Pokemons p = new();
            p.pokemonName = spvm.pokemonName;
            p.pokemonImg = spvm.pokemonImg;
            p.pokemonRegionId = spvm.pokemonRegionId;
            p.TypePrimaryPokemonId = spvm.TypePrimaryPokemonId;
            p.TypeSecondaryPokemonId = spvm.TypeSecondaryPokemonId;
            await _pr.addAsync(p);
        }

        public async Task Update(SavePokemonsViewModel spvm)
        {
            Pokemons p = new();
            p.id = spvm.id;
            p.pokemonName = spvm.pokemonName;
            p.pokemonImg = spvm.pokemonImg;
            p.pokemonRegionId = spvm.pokemonRegionId;
            p.TypePrimaryPokemonId = spvm.TypePrimaryPokemonId;
            p.TypeSecondaryPokemonId = spvm.TypeSecondaryPokemonId;
            await _pr.UpdateAsync(p);
        }

        public async Task Delete(int id) 
        {
            var pokemon = await _pr.GetOneAsync(id);
            await _pr.DeleteAsync(pokemon);

        }

        public async Task<SavePokemonsViewModel> GetOneByIdServices(int id)
        {
            var pokemons = await _pr.GetOneAsync(id);
            SavePokemonsViewModel sp = new();
            sp.id = sp.id;
            sp.pokemonName = pokemons.pokemonName;
            sp.pokemonImg = pokemons.pokemonImg;
            sp.pokemonRegionId = pokemons.pokemonRegionId;
            sp.TypePrimaryPokemonId = pokemons.TypePrimaryPokemonId;
            sp.TypeSecondaryPokemonId = pokemons.TypeSecondaryPokemonId;

            return sp;
        }

        public async Task<List<PokemonsViewModels>> GetAllPokemonsServices() 
        {
            var pokemonsList = await _pr.GetAllAsync();
            return pokemonsList.Select(p => new PokemonsViewModels 
            {
               id = p.id,
               pokemonName = p.pokemonName,
               pokemonImg = p.pokemonImg,
               pokemonRegions = p.pokemonRegions,
               typesPrimaryPokemons = p.typesPrimaryPokemons,
            }
            ).ToList();
        }
    }
}
