using CodeAcademyCoimpany.BLL.Interfaces;
using CodeAcademyCompany.DAL.Context;
using CodeAcademyCompany.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyCoimpany.BLL.Reposatory
{
    public class GenericRepository<T>  : IGenericRepository<T> where T : class
    {

        private readonly ApplicationDbContext _context; //==> EMPTY 

        public GenericRepository(ApplicationDbContext context)
        {
            //_context = new ApplicationDbContext()
            _context = context; //
        }


        public int Create(T item)
        {
            _context.Set<T>().Add(item);
            return _context.SaveChanges();
        }

        public int Delete(T item)
        {
            _context.Set<T>().Remove(item);
            return _context.SaveChanges();
        }

        public T Get(int id)
           => _context.Set<T>().Find(id);



        public IEnumerable<T> GetAll()
        {
            if(typeof(T) == typeof(Employee))
            {
               return (IEnumerable<T>)_context.Employees.Include(e=>e.Department).ToList();
                   
            }
            else { 
                  return  _context.Set<T>().ToList();
            
            }


        }

        public int Update(T item)
        {
            
            _context.Set<T>().Update(item);
            return _context.SaveChanges();
        }
    }
}
