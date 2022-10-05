using Applications.Services;
using Applications.ViewModel;
using DataBase;
using Microsoft.AspNetCore.Mvc;

namespace Pokedex.Controllers
{
    public class PokemonTypesController : Controller
    {

        private readonly PokemonsTypesServices _pokemonTypesServices;

        public PokemonTypesController(AplicationsContext DbContex)
        {
            _pokemonTypesServices = new(DbContex);
        }

        
        //index
        public async Task<IActionResult> Index()
        {
            return View(await _pokemonTypesServices.GetAllPokemonsServices());
        }

        //create
        public async Task<IActionResult> CreatePokemonsTypes()
        {
            return View("SavePokemonTypes", new SavePokemonTypeViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> CreatePokemonsTypes(SavePokemonTypeViewModel sptvm)
        {
            if (!ModelState.IsValid)
            {
                return View("SavePokemonTypes", sptvm);
            }

            await _pokemonTypesServices.Add(sptvm);
            return RedirectToRoute(new { controller = "PokemonTypes", action = "Index" });
        }

        //edit
        public async Task<IActionResult> EditPokemonsTypes(int id)
        {
            return View("SavePokemonTypes", await _pokemonTypesServices.GetOneByIdServices(id));
        }

        [HttpPost]
        public async Task<IActionResult> EditPokemonsTypes(SavePokemonTypeViewModel sptvm)
        {
            if (!ModelState.IsValid)
            {
                return View("SavePokemonTypes", sptvm);
            }

            await _pokemonTypesServices.Update(sptvm);
            return RedirectToRoute(new { controller = "PokemonTypes", action = "Index" });
        }

        //delete
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _pokemonTypesServices.GetOneByIdServices(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {

            await _pokemonTypesServices.Delete(id);
            return RedirectToRoute(new { controller = "PokemonTypes", action = "Index" });
        }
    }
}
