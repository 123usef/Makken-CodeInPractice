using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyCompany.DAL.Model
{
    public class Department
    {
        public int Id { get; set; }
       
        public string Code  { get; set; }
       
        [MaxLength(50)] // nvarchar(max)
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //Navigational Property many
        ICollection<Employee> Employes { get; set; } = new HashSet<Employee>();
    }
}
