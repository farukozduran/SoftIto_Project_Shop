using Microsoft.AspNetCore.Mvc;
using Project.Shop.Models;

namespace Project.Shop.Controllers
{
    public class CategoriesController : Controller
    {
        public readonly ApplicationDbContext context;

        public CategoriesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var result = context.Categories.ToList();
            return View(result);
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("Create");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = context.Categories.Find(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(int id, Category category)
        {
            context.Categories.Update(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = context.Categories.Find(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Delete(int id, Category category)
        {
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
