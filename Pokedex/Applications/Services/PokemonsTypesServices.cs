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
    public class PokemonsTypesServices : IPokemonTypeServices
    {
        private readonly IPokemonTypesRepository _pr;

        public PokemonsTypesServices(IPokemonTypesRepository appc)
        {
            _pr = appc;
        }

        public async Task<List<PokemonTypesViewModel>> GetAllPokemonsServices()
        {
            var pokemonsTypeList = await _pr.GetAllAsync();
            return pokemonsTypeList.Select(p => new PokemonTypesViewModel
            {
                id = p.id,
                typeName = p.typeName,
            }
            ).ToList();
        }

        public async Task<int> countPokemonTypeList() 
        {
            var c = await _pr.GetAllAsync();
            return c.Count();
        }

        public async Task Add(SavePokemonTypeViewModel spvm)
        {
            TypesPokemons p = new();
            p.typeName = spvm.typeName;
            await _pr.addAsync(p);
        }

        public async Task Update(SavePokemonTypeViewModel spvm)
        {
            TypesPokemons p = new();
            p.id = spvm.id;
            p.typeName = spvm.typeName;
            await _pr.UpdateAsync(p);
        }

        public async Task<SavePokemonTypeViewModel> GetOneByIdServices(int id)
        {
            var pokemonType = await _pr.GetOneAsync(id);
            SavePokemonTypeViewModel sp = new();
            sp.id = sp.id;
            sp.typeName = pokemonType.typeName;
            return sp;
        }

        public async Task Delete(int id)
        {
            var pokemonType = await _pr.GetOneAsync(id);
            await _pr.DeleteAsync(pokemonType);

        }

    }
}
