using Microsoft.AspNetCore.Mvc;

namespace Project.Shop.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
