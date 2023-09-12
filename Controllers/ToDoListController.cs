
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using ToDoMongoDB.Model.Models;
using ToDoMongoDB.Model.Repo;

namespace ToDoMongoDB.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly ToDoListRepo _toDoListRepo;
        public ToDoListController(ToDoListRepo toDoListRepo)
        {
            _toDoListRepo = toDoListRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var lists = _toDoListRepo.GetAsync().Result;
            return View(lists);
        }

        [HttpGet]
        public IActionResult Today()
        {
            return null;
        }

        [HttpGet]
        public IActionResult CreateView()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create()
        {
            return null;
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return null;
        }

        [HttpGet]
        public IActionResult EditView(int id)
        {
            return null;
        }

        [HttpPost]
        public IActionResult Edit()
        {
            return null;
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return null;
        }
    }
}
