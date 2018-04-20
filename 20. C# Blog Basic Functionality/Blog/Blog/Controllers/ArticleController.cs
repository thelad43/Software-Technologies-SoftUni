namespace Blog.Controllers
{
    using System.Linq;
    using Blog.Data;
    using Blog.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    public class ArticleController : Controller
    {
        private readonly BlogDbContext db;

        public ArticleController(BlogDbContext context)
        {
            this.db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult List()
        {
            var articles = this.db.Articles
                .Include(a => a.Author)
                .ToList();

            return View(articles);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = this.db.Articles
                .Include(a => a.Author)
                .FirstOrDefault(m => m.Id == id);

            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(Article article)
        {
            if (this.ModelState.IsValid)
            {
                var authorId = this.db.Users
                    .Where(u => u.UserName == this.User.Identity.Name)
                    .FirstOrDefault()
                    .Id;

                article.AuthorId = authorId;
                this.db.Articles.Add(article);
                this.db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(article);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = this.db.Articles
                .Include(a => a.Author)
                .Where(a => a.Id == id)
                .FirstOrDefault();

            if (IsUserAuthorizedToEdit(article) == false)
            {
                return Forbid();
            }

            if (article == null)
            {
                return NotFound();
            }

            var model = new ArticleViewModel
            {
                Id = article.Id,
                Title = article.Title,
                Content = article.Content
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ArticleViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var article = this.db.Articles
                    .FirstOrDefault(a => a.Id == model.Id);

                article.Title = model.Title;
                article.Content = model.Content;

                this.db.Update(article);
                this.db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = this.db.Articles
                .Include(a => a.Author)
                .FirstOrDefault(m => m.Id == id);

            if (IsUserAuthorizedToEdit(article) == false)
            {
                return Forbid();
            }

            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var article = this.db.Articles
                .Include(a => a.Author)
                .FirstOrDefault(m => m.Id == id);

            if (article == null)
            {
                return NotFound();
            }

            this.db.Articles.Remove(article);
            this.db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        private bool IsUserAuthorizedToEdit(Article article)
        {
            // checks whether user is authorized to edit (author or admin)
            if (this.User.IsInRole("Admin") ||
                article.IsAuthor(this.User.Identity.Name))
            {
                return true;
            }

            return false;
        }

        private bool ArticleExists(int id)
        {
            return this.db.Articles.Any(e => e.Id == id);
        }
    }
}