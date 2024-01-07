using Microsoft.AspNetCore.Mvc;
using TodoDemo.Data;
using TodoDemo.Models;

namespace TodoDemo.Controllers
{
    public class TodoController : Controller
    {
        private readonly ApplicationDbContext _context ;
        //public ApplicationDbContext _contexts { get; }
        public TodoController(ApplicationDbContext context)
        {
            _context = context ;
            
        }
        public IActionResult Index()
        {
            
            var todo = _context.todos.ToList();

            return View(todo);
        }
        //by default
        [HttpGet]
        public IActionResult Create(int id=0) {
            if(id == 0)
            {
            return View("Create");

            }
            else
            {
                var todo = _context.todos.Find(id);

                return View("Create", todo);
                //return RedirectToAction()
            }
        }

        [HttpPost]
        public IActionResult Create(Todo todo) {
            //var detaildtodo = _context.todos.Find(todo.Id);
            if(ModelState.IsValid)
            {
            //if (detaildtodo is null)
            //{
                _context.todos.Update(todo);
                _context.SaveChanges();
                return RedirectToAction("Index");
                //}
                //else
                //{
                //        _context.todos.Update(todo);
                //        _context.SaveChanges();
                //        return RedirectToAction("Index");
                    
                //}
                
            }
     
            return View(todo);
        }

        //public IActionResult Update(int id)
        //{
        //    var todo = _context.todos.Find(id);
        //    return View(todo);

        ////}
        //[HttpPost]
        //public IActionResult Update(Todo todo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.todos.Update(todo);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(todo);
        //}

        public IActionResult Delete(int id)
        {
            var todo = _context.todos.Find(id);
            _context.todos.Remove(todo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
