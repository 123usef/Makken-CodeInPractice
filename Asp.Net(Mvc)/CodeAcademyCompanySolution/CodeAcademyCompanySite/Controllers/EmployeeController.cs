using CodeAcademyCoimpany.BLL.Interfaces;
using CodeAcademyCompany.DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyCompany.PL.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IEmployeeRepository _EmployeeRepo;
        private readonly IDepartmentReposatory _departmentrepo;

        //IEmployeeReposatory depo = new EmployeeRepository();
        public EmployeeController(IEmployeeRepository Employeerepo , IDepartmentReposatory departmentrepo)
        {

            _EmployeeRepo = Employeerepo;
            _departmentrepo = departmentrepo;
        }


        public IActionResult Index(string search)
        {
            IEnumerable<Employee> emps;
            if (string.IsNullOrEmpty(search))
            {
                emps = _EmployeeRepo.GetAll();
            }
            else
            {
                emps = _EmployeeRepo.Search(search);
            }
           return View(emps);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var emp = _EmployeeRepo.Get(id.Value);
            return View(emp);

        }
        public IActionResult Create()
        {
            ViewBag.Departments = _departmentrepo.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            //if(dep == null)
            //{
            //    return BadRequest();
            //}
            _EmployeeRepo.Create(emp);

            return RedirectToAction("Index");
        }


        public IActionResult Update(int id)
        {
            var emp = _EmployeeRepo.Get(id);
            ViewBag.Departments = _departmentrepo.GetAll();
            return View(emp);
        }

        [HttpPost]
        public IActionResult Update(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _EmployeeRepo.Update(emp);
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public IActionResult Delete( int id)
        {
            var emp = _EmployeeRepo.Get(id);
            return View(emp);
        }
        [HttpPost , ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            var emp = _EmployeeRepo.Get(id);
            _EmployeeRepo.Delete(emp);
            return RedirectToAction("Index");
        }


    }
}
