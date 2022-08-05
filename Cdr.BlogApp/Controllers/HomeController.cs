using Cdr.BlogApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cdr.BlogApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()//action
        {
            //var obj = "dd";//compile time (derleme zamanı)
            //dynamic obje = 44;//runtime (çalışma zamanı)
            ViewBag.Baslik = "Ana Sayfa";
            ViewBag.Todo = new TodoItem { Id = 100, Title = "Test", IsDone = true };




            _logger.LogError("Index action da bir hata oluştu");
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Header"] = "Gizlilik Sayfası";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}