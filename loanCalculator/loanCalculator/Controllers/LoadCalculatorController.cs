using Aplication.Services;
using Aplication.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace loanCalculator.Controllers
{
    public class LoadCalculatorController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Total = LoanCalculatorServices.Instance.getData();
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoanCalculatorViewModel lc)
        {
            LoanCalculatorServices.Instance.calculator(lc);
            return RedirectToRoute(new { controller="LoadCalculator", action="Index" });
        }
    }
}
