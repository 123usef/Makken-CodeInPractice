using Microsoft.AspNetCore.Mvc;

namespace MyTodoList.Controllers
{
    public class AboutController : Controller
    {
        // By Deafult index action is Created
        public IActionResult Index()
        {
            return View();
        }
    }
}
