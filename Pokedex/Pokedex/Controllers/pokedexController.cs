using Microsoft.AspNetCore.Mvc;
using Pokedex.core.Application.Interfaces.Services;
using Pokedex.infraestruture.Persistence.Context;

namespace Pokedex.Controllers
{
    public class pokedexController : Controller
    {

        private readonly IPokemonServices _pokemonServices;
        private readonly IPokemonRegionServices _pokemonR;
        private readonly IPokemonTypeServices _pokemonT;


        public pokedexController(IPokemonRegionServices DbContex, IPokemonTypeServices DbContexT, IPokemonServices DbContextP ) 
        {

            _pokemonServices = DbContextP;
            _pokemonR = DbContex;
            _pokemonT = DbContexT;

        }

        public async Task<IActionResult>Index()
        {
            await _pokemonR.GetAllPokemonsServices();
            await _pokemonT.GetAllPokemonsServices();

            return View(await _pokemonServices.GetAllPokemonsServices());
        }
    }
}
