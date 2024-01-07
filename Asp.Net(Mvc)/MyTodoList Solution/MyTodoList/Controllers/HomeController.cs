using Microsoft.AspNetCore.Mvc;
using MyTodoList.Models;
using System.Diagnostics;

namespace MyTodoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id , string name , Employee obj)
            {

            return View();
        }

        public IActionResult Greeting()
        {
            ContentResult content = new ContentResult();
            content.Content = "Hello World ";
            content.ContentType = "application/pdf";
            return content;
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
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
