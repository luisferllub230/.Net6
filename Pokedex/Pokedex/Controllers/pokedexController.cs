using Applications.Services;
using DataBase;
using Microsoft.AspNetCore.Mvc;

namespace Pokedex.Controllers
{
    public class pokedexController : Controller
    {

        private readonly PokemonServices _pokemonServices;


        public pokedexController(AplicationsContext DbContex) 
        {

            _pokemonServices = new(DbContex);

        }

        public async Task<IActionResult>Index()
        {
            return View(await _pokemonServices.GetAllPokemonsServices());
        }
    }
}
