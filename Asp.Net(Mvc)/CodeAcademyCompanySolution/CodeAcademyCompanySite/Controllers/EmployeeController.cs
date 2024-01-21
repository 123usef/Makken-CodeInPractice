using AutoMapper;
using CodeAcademyCoimpany.BLL.Interfaces;
using CodeAcademyCompany.DAL.Model;
using CodeAcademyCompany.PL.Helpers;
using CodeAcademyCompany.PL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace CodeAcademyCompany.PL.Controllers
{
	[Authorize]
	public class EmployeeController : Controller
    {

        //private readonly IEmployeeRepository _EmployeeRepo;
        //private readonly IDepartmentReposatory _departmentrepo;
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        //IEmployeeReposatory depo = new EmployeeRepository();
        public EmployeeController(/*IEmployeeRepository Employeerepo , IDepartmentReposatory departmentrepo*/ IUnitofWork unitofWork , IMapper mapper)
        {

            //_EmployeeRepo = Employeerepo;
            //_departmentrepo = departmentrepo;
            _unitofWork = unitofWork;
            _mapper = mapper;
        }


        public IActionResult Index(string search)
        {
            IEnumerable<Employee> emps;
            if (string.IsNullOrEmpty(search))
            {  
                emps = _unitofWork.EmployeeRepository.GetAll();
                //var Mappedemps = _mapper.Map<Employee, EmployeeVM>(emps);
            }
            else
            {
                emps = _unitofWork.EmployeeRepository.Search(search);
            }
           return View(emps);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var emp = _unitofWork.EmployeeRepository.Get(id.Value);
            return View(emp);

        }
        public IActionResult Create()
        {
            ViewBag.Departments = _unitofWork.DepartmentReposatory.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeVM emp)
        {
            ///if(dep == null)
            ///{
            ///    return BadRequest();
            ///}
            /*
               Type Casting EmployeeVm --> Employee 
             
             */

            /// Manaual Mapping 
            ///Employee MappedEmp = new Employee()
            ///{
            ///    Name = emp.Name,
            ///    City = emp.City,
            ///    Email =emp.Email , 
            ///    age= emp.age ,
            ///    Salary = emp.Salary ,
            ///    DepartmentId = emp.DepartmentId,

            ///};
            emp.ImageUrl = DocumentConf.DocumentUpload(emp.Image, "Images");
            var MappedEmp = _mapper.Map<EmployeeVM , Employee>(emp);
            _unitofWork.EmployeeRepository.Create(MappedEmp);

            return RedirectToAction("Index");
        }


        public IActionResult Update(int id)
        {
            var emp = _unitofWork.EmployeeRepository.Get(id);
            ViewBag.Departments = _unitofWork.DepartmentReposatory.GetAll();
            return View(emp);
        }

        [HttpPost]
        public IActionResult Update(EmployeeVM emp)
        {
            if (ModelState.IsValid)
            {
                var MappedEmp = _mapper.Map<EmployeeVM, Employee>(emp);
                _unitofWork.EmployeeRepository.Update(MappedEmp);
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public IActionResult Delete( int id)
        {
            var emp = _unitofWork.EmployeeRepository.Get(id);
            return View(emp);
        }
        [HttpPost , ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            var emp = _unitofWork.EmployeeRepository.Get(id);
            DocumentConf.DcoumentDelete(emp.ImageUrl, "Images");
            _unitofWork.EmployeeRepository.Delete(emp);
            return RedirectToAction("Index");
        }


    }
}
