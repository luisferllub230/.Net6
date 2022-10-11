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
    public class PokemonRegionServices : IPokemonRegionServices
    {
        private readonly IPokemonRegionRepository _pr;

        public PokemonRegionServices(IPokemonRegionRepository appc)
        {
            _pr = appc;
        }

        public async Task<List<PokemonRegionViewModel>> GetAllPokemonsServices()
        {
            var pokemonsRegionList = await _pr.GetAllAsync();
            return pokemonsRegionList.Select(p => new PokemonRegionViewModel
            {
                id = p.id,
                pokemonRegionsName = p.pokemonRegionsName
            }
            ).ToList();
        }

        public async Task<int> countPokemonRegionList()
        {
            var c = await _pr.GetAllAsync();
            return c.Count();
        }

        public async Task Add(SavePokemonRegionViewModel spvm)
        {
            PokemonRegions p = new();
            p.pokemonRegionsName = spvm.pokemonRegionsName;
            await _pr.addAsync(p);
        }

        public async Task<int> countPokemonTypeList()
        {
            var c = await _pr.GetAllAsync();
            return c.Count();
        }

        public async Task Update(SavePokemonRegionViewModel spvm)
        {
            PokemonRegions p = new();
            p.id = spvm.id;
            p.pokemonRegionsName = spvm.pokemonRegionsName;
            await _pr.UpdateAsync(p);
        }

        public async Task<SavePokemonRegionViewModel> GetOneByIdServices(int id)
        {
            var pokemonRegions = await _pr.GetOneAsync(id);
            SavePokemonRegionViewModel sp = new();
            sp.id = sp.id;
            sp.pokemonRegionsName = pokemonRegions.pokemonRegionsName;
            return sp;
        }

        public async Task Delete(int id)
        {
            var pokemonRegions = await _pr.GetOneAsync(id);
            await _pr.DeleteAsync(pokemonRegions);
        }

    }
}
