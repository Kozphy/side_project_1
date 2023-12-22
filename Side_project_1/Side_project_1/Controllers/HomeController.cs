using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Side_project_1.Models;
using Side_project_1.Models.ViewModels;
using System.Collections.Generic;
using System.Net.Http;

namespace Side_project_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _httpClientFactory = null!;
        private HomeIndexVm _HomeindexVm = new HomeIndexVm();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<ThumbnailImg> thumbnailsImgs = new List<ThumbnailImg>()
            {
                new ThumbnailImg(){ 
                    Location=@"C:\Users\dbdf0\source\repos\interview_project\Side_project_1\Side_project_1\wwwroot\image\index\Home\Services\coffee1.png",
                },
                new ThumbnailImg()
                {
                    Location = @"C:\Users\dbdf0\source\repos\interview_project\Side_project_1\Side_project_1\wwwroot\image\index\Home\Services\coffee2.png",
                },
                new ThumbnailImg()
                {
                    Location = @"C:\Users\dbdf0\source\repos\interview_project\Side_project_1\Side_project_1\wwwroot\image\index\Home\Services\coffee3.png",
                },
                new ThumbnailImg()
                {
                    Location = @"C:\Users\dbdf0\source\repos\interview_project\Side_project_1\Side_project_1\wwwroot\image\index\Home\Services\coffee4.png",
                }
            };

            _HomeindexVm.thumbnailImgs = thumbnailsImgs;
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
            return View(_HomeindexVm);
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