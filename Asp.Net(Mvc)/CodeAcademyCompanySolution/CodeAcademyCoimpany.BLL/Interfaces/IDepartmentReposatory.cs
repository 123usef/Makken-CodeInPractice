using CodeAcademyCompany.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyCoimpany.BLL.Interfaces
{
    public interface IDepartmentReposatory
    {
        // 5 actions ==> Get All , get , create ,  delete, update
        IEnumerable<Department> GetAll();
        Department Get(int id);
        // 
        int Create(Department dep); 
        int Update(Department dep);
        int Delete(Department  dep );
    
    }
}
/*
    create(){

    modelstate is valid
    _context.Departmenrt.add(dep)
    _context.SaveChanges() ==> NUmber of Rows Affected in Database 
 
 
 
 */