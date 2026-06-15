using Microsoft.AspNetCore.Mvc;
using Project.Shop.Models;

namespace Project.Shop.Controllers
{
    public class CustomersController : Controller
    {
        public readonly ApplicationDbContext context;

        public CustomersController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var result = context.Customers.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = context.Categories.Find(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(int id, Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = context.Customers.Find(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Delete(int id, Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
