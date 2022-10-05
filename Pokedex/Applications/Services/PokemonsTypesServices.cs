using Applications.Repository;
using Applications.ViewModel;
using DataBase;
using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Services
{
    public class PokemonsTypesServices
    {
        private readonly PokemonsTypesRepositore _pr;

        public PokemonsTypesServices(AplicationsContext appc)
        {
            _pr = new(appc);
        }

        public async Task<List<PokemonTypesViewModel>> GetAllPokemonsServices()
        {
            var pokemonsTypeList = await _pr.GetAllAsync();
            return pokemonsTypeList.Select(p => new PokemonTypesViewModel
            {
                id = p.id,
                typeName = p.typeName
            }
            ).ToList();
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
