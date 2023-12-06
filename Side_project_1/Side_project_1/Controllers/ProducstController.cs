using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Side_project_1.Controllers
{
    [Route("Products")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Products() {

            return View();
        }

        [HttpGet("{Product}/{id}")]
        //[Route("{id:int}")]
        public IActionResult Product(int id)
        {
            List<string> s = new List<string>{ "s", "bl", "c" };
            Console.WriteLine(id);
            return View();
        }

        public IActionResult MessageBoard()
        {
            return View();
        }
    }
}
