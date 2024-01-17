using AutoMapper;
using CodeAcademyCoimpany.BLL.Interfaces;
using CodeAcademyCoimpany.BLL.Reposatory;
using CodeAcademyCompany.DAL.Model;
using CodeAcademyCompany.PL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyCompany.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentReposatory _departmentRepo;
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        //IDepartmentReposatory depo = new DepartmentRepository();
        public DepartmentController(/*IDepartmentReposatory departmentrepo */IUnitofWork unitofWork , IMapper mapper)
        {

            //_departmentRepo = departmentrepo;
            _unitofWork = unitofWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {

            // ViewBag || ViewdData
            ViewBag.massage = "Hello from Action";
            ViewData["msg"] = "Hello from ViewData";
           var deps =  _unitofWork.DepartmentReposatory.GetAll();
            return View(deps);
        }
        public IActionResult Details( int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var dep = _unitofWork.DepartmentReposatory.Get(id.Value);
            return View(dep);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DepartmentVM dep)
        {
           
            if (ModelState.IsValid)
            {
                var MappedDep = _mapper.Map<DepartmentVM, Department>(dep);
            _unitofWork.DepartmentReposatory.Create(MappedDep);
                TempData["success"] = "Added Successfully";
            return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Update(int id)
        {
            var dep = _unitofWork.DepartmentReposatory.Get(id);
            return View(dep);
        }

        [HttpPost]
        public IActionResult Update(DepartmentVM dep)
        {
            if(ModelState.IsValid)
            {
                var MappedDep = _mapper.Map<DepartmentVM, Department>(dep);
                _unitofWork.DepartmentReposatory.Update(MappedDep);
            return RedirectToAction("Index");
            }
            return View(dep);
        }

        public ActionResult Delete(int id)
        {
            var dep = _unitofWork.DepartmentReposatory.Get(id);
            _unitofWork.DepartmentReposatory.Delete(dep);
            return RedirectToAction("Index");
        }

    }
}
