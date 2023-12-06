using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Side_project_1.Models;
using Side_project_1.Models.ViewModels;
using System.Collections.Generic;

namespace Side_project_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // create thumbnailImg and return to index.cshtml
            //List<HomeIndexVm> homeIndexVms = new List<HomeIndexVm> 
            //{
            //    new List<ThumbnailImg> thumbnail
            //};

            //List<ThunbnailImg> thunbnailImgs =
            //   new List<ThunbnailImg>() {
            //        new ThunbnailImg(){ },
            //        new ThunbnailImg(){ },
            //        new ThunbnailImg(){ },
            //        new ThunbnailImg(){ },
            //   };
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}