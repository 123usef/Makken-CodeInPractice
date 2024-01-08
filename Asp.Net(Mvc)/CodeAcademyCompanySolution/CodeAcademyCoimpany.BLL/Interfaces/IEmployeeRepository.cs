using CodeAcademyCompany.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyCoimpany.BLL.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        // 
        int Create(Employee emp);
        int Update(Employee emp);
        int Delete(Employee emp);
    }
}
