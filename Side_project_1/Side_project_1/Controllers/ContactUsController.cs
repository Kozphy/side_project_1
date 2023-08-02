using Microsoft.AspNetCore.Mvc;

namespace Side_project_1.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
