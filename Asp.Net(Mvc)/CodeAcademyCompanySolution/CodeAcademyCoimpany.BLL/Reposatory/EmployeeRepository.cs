using CodeAcademyCoimpany.BLL.Interfaces;
using CodeAcademyCompany.DAL.Context;
using CodeAcademyCompany.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyCoimpany.BLL.Reposatory
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context; //==> EMPTY 

        public EmployeeRepository(ApplicationDbContext context)
        {
            //_context = new ApplicationDbContext()
            _context = context; //
        }


        public int Create(Employee dep)
        {
            _context.Employees.Add(dep);
            return _context.SaveChanges();
        }

        public int Delete(Employee dep)
        {
            _context.Employees.Remove(dep);
            return _context.SaveChanges();
        }

        public Employee Get(int id)
           => _context.Employees.Find(id);



        public IEnumerable<Employee> GetAll()
             => _context.Employees.ToList();


        public int Update(Employee dep)
        {
            _context.Employees.Update(dep);
            return _context.SaveChanges();
        }
    }
}
