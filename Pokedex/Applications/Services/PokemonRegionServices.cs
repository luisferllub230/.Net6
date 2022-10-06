using Applications.Repository;
using Applications.ViewModel;
using DataBase.Models;
using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Services
{
    public class PokemonRegionServices
    {
        private readonly PokemonRegionRepository _pr;

        public PokemonRegionServices(AplicationsContext appc)
        {
            _pr = new(appc);
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

        public async Task Add(SavePokemonRegionViewModel spvm)
        {
            PokemonRegions p = new();
            p.pokemonRegionsName = spvm.pokemonRegionsName;
            await _pr.addAsync(p);
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
