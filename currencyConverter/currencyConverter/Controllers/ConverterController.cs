using Aplication.Services;
using Aplication.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace currencyConverter.Controllers
{
    public class ConverterController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.totalConvert = ConverServices.Instance.getTotalConvert();
            ViewBag.NameConverter = ConverServices.Instance.getConverterName();
            return View();
        }

        [HttpPost]
        public IActionResult Index(CoverterViewModel co)
        {
            ConverServices.Instance.takeData(co);
            return RedirectToRoute(new { controller = "Converter", action = "Index" });
        }
    }
}
