using Pokedex.core.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.core.Application.Interfaces.Services
{
    public interface IPokemonServices
    {
        Task Add(SavePokemonsViewModel spvm);
        Task Update(SavePokemonsViewModel spvm);
        Task Delete(int id);
        Task<SavePokemonsViewModel> GetOneByIdServices(int id);
        Task<List<PokemonsViewModels>> GetAllPokemonsServices();

    }
}
