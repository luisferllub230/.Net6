using Microsoft.AspNetCore.Mvc;

namespace Pokedex.Controllers
{
    public class pokedexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
