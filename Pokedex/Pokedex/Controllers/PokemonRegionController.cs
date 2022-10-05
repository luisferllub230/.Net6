using Microsoft.AspNetCore.Mvc;

namespace Pokedex.Controllers
{
    public class PokemonRegionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
