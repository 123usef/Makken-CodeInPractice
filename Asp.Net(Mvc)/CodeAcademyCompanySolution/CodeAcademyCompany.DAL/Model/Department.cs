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
        [Required(ErrorMessage = "Code is Required for the Department")]
        public string Code  { get; set; }
        [Required(ErrorMessage = "Name is Required for the Department")]
        [MaxLength(50)] // nvarchar(max)
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //Navigational Property many
        ICollection<Employee> Employes { get; set; } = new HashSet<Employee>();
    }
}
