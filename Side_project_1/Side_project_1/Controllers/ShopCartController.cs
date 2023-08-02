using Microsoft.AspNetCore.Mvc;

namespace Side_project_1.Controllers
{
    public class ShopCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
