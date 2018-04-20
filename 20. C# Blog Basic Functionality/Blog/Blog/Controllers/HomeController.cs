namespace Blog.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("List", "Article");
        }
    }
}