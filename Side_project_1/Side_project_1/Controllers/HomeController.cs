using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Side_project_1.Models;
using Side_project_1.Models.ViewModels;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;

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
                    Title="coffee1",
                    Location=@"/image/index/Home/Services/coffee1.png",
                    Content=@"/image/ThumbnailImg1.jpg",
                    Description=@"Describes the acidity (liveliness and sharpness) of brewed coffee."
                },
                new ThumbnailImg()
                {
                    Title="coffee2",
                    Location = @"/image/index/Home/Services/coffee2.jpg",
                    Content=@"/image/ThumbnailImg2.jpg",
                    Description=@"Describes the acidity (liveliness and sharpness) of brewed coffee."
                },
                new ThumbnailImg()
                {
                    Title="coffee3",
                    Location = @"/image/index/Home/Services/coffee3.jpg",
                    Content=@"/image/ThumbnailImg3.jpg",
                    Description=@"Describes the remaining flavor in the mouth, once the coffee is swallowed."
                },
                new ThumbnailImg()
                {
                    Title="coffee4",
                    Location = @"/image/index/Home/Services/coffee4.jpg",
                    Content=@"/image/ThumbnailImg4.jpg",
                    Description=@" Describes the smell of brewed coffee. See more below – we include 63 words used to describe coffee aroma."
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