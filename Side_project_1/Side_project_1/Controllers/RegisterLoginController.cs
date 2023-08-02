using Microsoft.AspNetCore.Mvc;

namespace Side_project_1.Controllers
{
    public class RegisterLoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
    }
}
