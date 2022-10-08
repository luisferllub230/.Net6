using Applications.Services;
using Applications.ViewModel;
using DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Pokedex.Controllers
{
    public class PokemonsController : Controller
    {
        private readonly PokemonServices _pokemonServices;
        private readonly PokemonRegionServices _pokemonR;
        private readonly PokemonsTypesServices _pokemonT;

        public PokemonsController(AplicationsContext DbContex)
        {

            _pokemonServices = new(DbContex);
            _pokemonR = new(DbContex);
            _pokemonT = new(DbContex);

        }

        public async Task<IActionResult> Index()
        {
            await _pokemonR.GetAllPokemonsServices();

            ViewBag.PokemonsT = await _pokemonT.GetAllPokemonsServices();
            ViewBag.CountT = await _pokemonT.countPokemonTypeList();

            return View(await _pokemonServices.GetAllPokemonsServices());
        }

        //create
        public async Task<IActionResult> CreatePokemons()
        {
            ViewBag.PokemonsT = await _pokemonT.GetAllPokemonsServices();
            ViewBag.CountT = await _pokemonT.countPokemonTypeList();

            ViewBag.PokemonsR = await _pokemonR.GetAllPokemonsServices();
            ViewBag.CountR = await _pokemonR.countPokemonTypeList();

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
            ViewBag.PokemonsT = await _pokemonT.GetAllPokemonsServices();
            ViewBag.CountT = await _pokemonT.countPokemonTypeList();

            ViewBag.PokemonsR = await _pokemonR.GetAllPokemonsServices();
            ViewBag.CountR = await _pokemonR.countPokemonTypeList();
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
