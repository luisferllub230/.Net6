using Pokedex.core.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.core.Application.Interfaces.Services
{
    public interface IPokemonTypeServices
    {
        Task<List<PokemonTypesViewModel>> GetAllPokemonsServices();
        Task<int> countPokemonTypeList();
        Task Add(SavePokemonTypeViewModel spvm);
        Task Update(SavePokemonTypeViewModel spvm);
        Task<SavePokemonTypeViewModel> GetOneByIdServices(int id);
        Task Delete(int id);
    }
}
