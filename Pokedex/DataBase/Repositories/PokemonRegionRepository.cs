using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokedex.infraestruture.Persistence.Context;
using Pokedex.core.Domain.Entities;
using Pokedex.core.Application.Interfaces.Repositories;

namespace Pokedex.infraestruture.Persistence.Repositories
{
    public class PokemonRegionRepository : IPokemonRegionRepository
    {
        private readonly AplicationsContext _context;

        public PokemonRegionRepository(AplicationsContext Dbcontex)
        {
            _context = Dbcontex;
        }


        //add
        public async Task addAsync(PokemonRegions p)
        {
            await _context.PokemonRegions.AddAsync(p);
            await _context.SaveChangesAsync();
        }

        //update
        public async Task UpdateAsync(PokemonRegions p)
        {
            _context.Entry(p).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        //delete
        public async Task DeleteAsync(PokemonRegions p)
        {
            _context.Set<PokemonRegions>().Remove(p);
            await _context.SaveChangesAsync();
        }


        //getAll
        public async Task<List<PokemonRegions>> GetAllAsync()
        {
            return await _context.Set<PokemonRegions>().ToListAsync();
        }

        //getOne
        public async Task<PokemonRegions> GetOneAsync(int id)
        {
            return await _context.Set<PokemonRegions>().FindAsync(id);
        }
    }
}
