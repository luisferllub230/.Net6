using Applications.Services;
using Applications.ViewModel;
using DataBase;
using Microsoft.AspNetCore.Mvc;

namespace Pokedex.Controllers
{
    public class PokemonsController : Controller
    {
        private readonly PokemonServices _pokemonServices;


        public PokemonsController(AplicationsContext DbContex)
        {

            _pokemonServices = new(DbContex);

        }

        public async Task<IActionResult> Index()
        {
            return View(await _pokemonServices.GetAllPokemonsServices());
        }

        //create
        public async Task<IActionResult> CreatePokemons()
        {
            return View("SavePokemons", new SavePokemonsViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> CreatePokemons(SavePokemonsViewModel spvm)
        {
            if (!ModelState.IsValid) 
            {
                return View("SavePokemons", spvm);
            }

            await _pokemonServices.Add(spvm);
            return RedirectToRoute(new { controller="Pokemons", action="Index" });
        }

        //edit
        public async Task<IActionResult> EditPokemons(int id)
        {
            return View("SavePokemons", await _pokemonServices.GetOneByIdServices(id));
        }

        [HttpPost]
        public async Task<IActionResult> EditPokemons(SavePokemonsViewModel spvm)
        {
            if (!ModelState.IsValid)
            {
                return View("SavePokemons", spvm);
            }

            await _pokemonServices.Update(spvm);
            return RedirectToRoute(new { controller = "Pokemons", action = "Index" });
        }

        //delect
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _pokemonServices.GetOneByIdServices(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            
            await _pokemonServices.Delete(id);
            return RedirectToRoute(new { controller = "Pokemons", action = "Index" });
        }

    }
}
