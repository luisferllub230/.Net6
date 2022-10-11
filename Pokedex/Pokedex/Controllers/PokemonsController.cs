using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pokedex.core.Application.Interfaces.Services;
using Pokedex.core.Application.ViewModel;
using Pokedex.infraestruture.Persistence.Context;

namespace Pokedex.Controllers
{
    public class PokemonsController : Controller
    {
        private readonly IPokemonServices _pokemonServices;

        public PokemonsController(IPokemonServices DbContex)
        {

            _pokemonServices = DbContex;

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
