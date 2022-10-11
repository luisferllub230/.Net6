using Pokedex.core.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.core.Application.Interfaces.Services
{
    public interface IPokemonRegionServices
    {
        Task<List<PokemonRegionViewModel>> GetAllPokemonsServices();
        Task<int> countPokemonRegionList();
        Task Add(SavePokemonRegionViewModel spvm);
        Task<int> countPokemonTypeList();
        Task Update(SavePokemonRegionViewModel spvm);
        Task<SavePokemonRegionViewModel> GetOneByIdServices(int id);
        Task Delete(int id);
    }
}
