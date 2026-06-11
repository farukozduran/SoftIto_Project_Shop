using Microsoft.AspNetCore.Mvc;

namespace Project.Shop.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
