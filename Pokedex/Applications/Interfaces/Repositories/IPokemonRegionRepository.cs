using Pokedex.core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.core.Application.Interfaces.Repositories
{
    public interface IPokemonRegionRepository
    {
        Task addAsync(PokemonRegions p);
        Task UpdateAsync(PokemonRegions p);
        Task DeleteAsync(PokemonRegions p);
        Task<List<PokemonRegions>> GetAllAsync();
        Task<PokemonRegions> GetOneAsync(int id);
    }
}
