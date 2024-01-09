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
   public class DepartmentRepository : GenericRepository<Department>, IDepartmentReposatory
    {
        public DepartmentRepository(ApplicationDbContext context) :base(context)
        {
            
        }
    }
}
