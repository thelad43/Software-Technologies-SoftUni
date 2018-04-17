namespace CalculatorApp.Controllers
{
    using CalculatorApp.Models;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }

        [HttpPost]
        public IActionResult Calculate(Calculator calculator)
        {
            calculator.CalculateResult();
            return RedirectToAction("Index", calculator);
        }
    }
}