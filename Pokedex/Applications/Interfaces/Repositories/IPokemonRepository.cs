using Pokedex.core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.core.Application.Interfaces.Repositories
{
    public interface IPokemonRepository
    {
        Task addAsync(Pokemons p);
        Task UpdateAsync(Pokemons p);
        Task DeleteAsync(Pokemons p);
        Task<List<Pokemons>> GetAllAsync();
        Task<Pokemons> GetOneAsync(int id);
    }
}
