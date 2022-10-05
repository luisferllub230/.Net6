using DataBase.Models;
using DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Repository
{
    public class PokemonsTypesRepositore
    {
        private readonly AplicationsContext _context;

        public PokemonsTypesRepositore(AplicationsContext Dbcontex)
        {
            _context = Dbcontex;
        }


        //add
        public async Task addAsync(TypesPokemons p)
        {
            await _context.TypesPokemons.AddAsync(p);
            await _context.SaveChangesAsync();
        }

        //update
        public async Task UpdateAsync(TypesPokemons p)
        {
            _context.Entry(p).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        //delete
        public async Task DeleteAsync(TypesPokemons p)
        {
            _context.Set<TypesPokemons>().Remove(p);
            await _context.SaveChangesAsync();
        }


        //getAll
        public async Task<List<TypesPokemons>> GetAllAsync()
        {
            return await _context.Set<TypesPokemons>().ToListAsync();
        }

        //getOne
        public async Task<TypesPokemons> GetOneAsync(int id)
        {
            return await _context.Set<TypesPokemons>().FindAsync(id);
        }
    }
}
