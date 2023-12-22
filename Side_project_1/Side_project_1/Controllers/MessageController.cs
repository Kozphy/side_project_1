using Microsoft.AspNetCore.Mvc;

namespace Side_project_1.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
