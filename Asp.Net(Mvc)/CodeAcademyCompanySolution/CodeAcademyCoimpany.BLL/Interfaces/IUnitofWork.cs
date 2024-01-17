using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyCoimpany.BLL.Interfaces
{
    public interface IUnitofWork
    {
        public IEmployeeRepository EmployeeRepository { get; set; }
        public IDepartmentReposatory DepartmentReposatory { get; set; }

    }
}
