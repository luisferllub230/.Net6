using Aplication.Services;
using Aplication.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ZodiacApp.Controllers
{
    public class ZodiacController : Controller
    {
        private readonly ShowZodiac _sz;

        public ZodiacController() 
        {
            _sz = new ShowZodiac();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FormViewModel fv)
        {
            _sz.showZ(fv);

            return RedirectToRoute(new { controller = "Zodiac", action = "myZodiac" });
        }

        public IActionResult myZodiac() 
        {
            //ZodiacListViewModel sz = new ZodiacListViewModel();
            //sz.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "pepe"});
            return View(_sz.getAll());
        } 
    }
}
