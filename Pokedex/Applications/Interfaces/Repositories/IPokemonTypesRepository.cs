using Pokedex.core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.core.Application.Interfaces.Repositories
{
    public interface IPokemonTypesRepository
    {
        Task addAsync(TypesPokemons p);
        Task UpdateAsync(TypesPokemons p);
        Task DeleteAsync(TypesPokemons p);
        Task<List<TypesPokemons>> GetAllAsync();
        Task<TypesPokemons> GetOneAsync(int id);
    }
}
