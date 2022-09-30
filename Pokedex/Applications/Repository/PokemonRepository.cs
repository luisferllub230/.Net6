using DataBase;
using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Repository
{
    public class PokemonRepository
    {
        private readonly AplicationsContext _context;

        public PokemonRepository( AplicationsContext Dbcontex) 
        {
            _context = Dbcontex;    
        }


        //add pokemon
        public async Task addAsync(Pokemons p) 
        {
            await _context.Pokemons.AddAsync(p);
            await _context.SaveChangesAsync();
        }

        //update
        public async Task UpdateAsync(Pokemons p)
        {
            _context.Entry(p).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        //delete
        public async Task DeleteAsync(Pokemons p)
        {
            _context.Set<Pokemons>().Remove(p);
            await _context.SaveChangesAsync();
        }


        //getAll
        public async Task<List<Pokemons>> GetAllAsync() 
        {
            return await _context.Set<Pokemons>().ToListAsync();
        }

        //getOne
        public async Task<Pokemons> GetOneAsync(int id) 
        {
            return await _context.Set<Pokemons>().FindAsync(id);
        }
    }
}
