using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Side_project_1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Products() { 
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }

        public IActionResult MessageBoard()
        {
            return View();
        }
    }
}
