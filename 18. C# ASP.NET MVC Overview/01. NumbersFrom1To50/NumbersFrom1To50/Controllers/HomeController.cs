namespace NumbersFrom1To50.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using NumbersFrom1To50.Models;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            this.ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            this.ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}