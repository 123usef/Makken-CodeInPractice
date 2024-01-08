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
   public class DepartmentRepository : IDepartmentReposatory
    {
        private readonly ApplicationDbContext _context; //==> EMPTY 

        public DepartmentRepository( ApplicationDbContext context )
        {
            //_context = new ApplicationDbContext()
            _context = context; //
        }


        public int Create(Department dep)
        {
            _context.Departments.Add( dep );
            return _context.SaveChanges();
        }

        public int Delete(Department dep)
        { 
            _context.Departments.Remove(dep);
              return _context.SaveChanges();
         }

        public Department Get(int id)
           =>  _context.Departments.Find(id);
            
            
      
        public IEnumerable<Department> GetAll()
             =>  _context.Departments.ToList();
        

        public int Update(Department dep)
        {
            _context.Departments.Update(dep);
            return _context.SaveChanges();
        }
    }
}
