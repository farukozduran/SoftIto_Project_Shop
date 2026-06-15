using Microsoft.AspNetCore.Mvc;

namespace Project.Shop.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
