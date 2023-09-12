using Microsoft.AspNetCore.Mvc;

namespace ToDoMongoDB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Today()
        {
            return View();
        }

        public IActionResult Favorite()
        {
            return View();
        }

        public IActionResult Lists()
        {
            return View();
        }

        public IActionResult Completed()
        {
            return View();
        }

    }
}
