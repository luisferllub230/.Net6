using Applications.Services;
using DataBase;
using Microsoft.AspNetCore.Mvc;

namespace Pokedex.Controllers
{
    public class pokedexController : Controller
    {

        private readonly PokemonServices _pokemonServices;
        private readonly PokemonRegionServices _pokemonR;
        private readonly PokemonsTypesServices _pokemonT;


        public pokedexController(AplicationsContext DbContex) 
        {

            _pokemonServices = new(DbContex);
            _pokemonR = new(DbContex);
            _pokemonT = new(DbContex);

        }

        public async Task<IActionResult>Index()
        {
            await _pokemonR.GetAllPokemonsServices();
            await _pokemonT.GetAllPokemonsServices();

            return View(await _pokemonServices.GetAllPokemonsServices());
        }
    }
}
