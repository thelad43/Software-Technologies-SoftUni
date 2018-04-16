namespace TODOList.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using TODOList.Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new TaskDbContext();

            using (db)
            {
                var tasks = db.Tasks.ToList();
                return View(tasks);
            }
        }
    }
}