using ASPTranslator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASPTranslator.Controllers
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
            var translation = new TranslationModel();
            //var testText = "hello world";

            //try
            //{
            //    var targetLanguage = "";
            //    var sourceLanguage = "";
            //    var googleApi = new GoogleApi();
            //    var result = googleApi.GetTranslation("Hello World", targetLanguage, sourceLanguage);
            //}
            //catch (Exception ex) 
            //{
            //    var tmp = ex;
            //}
            

            return View(translation);
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

        public IActionResult Translate(TranslationModel translation)
        {
            var googleApi = new GoogleApi();
            
            
            return View(googleApi.GetTranslation(translation));
        }




    }
}
