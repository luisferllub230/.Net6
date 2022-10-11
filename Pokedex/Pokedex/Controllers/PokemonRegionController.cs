﻿using Microsoft.AspNetCore.Mvc;
using Pokedex.core.Application.Interfaces.Services;
using Pokedex.core.Application.ViewModel;
using Pokedex.infraestruture.Persistence.Context;

namespace Pokedex.Controllers
{
    public class PokemonRegionController : Controller
    {
        private readonly IPokemonRegionServices _pokemonRegionServices;

        public PokemonRegionController(IPokemonRegionServices DbContex)
        {
            _pokemonRegionServices = DbContex;
        }


        //index
        public async Task<IActionResult> Index()
        {
            return View(await _pokemonRegionServices.GetAllPokemonsServices());
        }

        //create
        public async Task<IActionResult> CreatePokemonsRegion()
        {
            return View("SavePokemonRegion", new SavePokemonRegionViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> CreatePokemonsRegion(SavePokemonRegionViewModel sptvm)
        {
            if (!ModelState.IsValid)
            {
                return View("SavePokemonRegion", sptvm);
            }

            await _pokemonRegionServices.Add(sptvm);
            return RedirectToRoute(new { controller = "PokemonRegion", action = "Index" });
        }

        //edit
        public async Task<IActionResult> EditPokemonsRegion(int id)
        {
            return View("SavePokemonRegion", await _pokemonRegionServices.GetOneByIdServices(id));
        }

        [HttpPost]
        public async Task<IActionResult> EditPokemonsRegion(SavePokemonRegionViewModel sptvm)
        {
            if (!ModelState.IsValid)
            {
                return View("SavePokemonRegion", sptvm);
            }

            await _pokemonRegionServices.Update(sptvm);
            return RedirectToRoute(new { controller = "PokemonRegion", action = "Index" });
        }

        //delete
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _pokemonRegionServices.GetOneByIdServices(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {

            await _pokemonRegionServices.Delete(id);
            return RedirectToRoute(new { controller = "PokemonRegion", action = "Index" });
        }
    }
}
