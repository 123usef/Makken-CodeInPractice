using CodeAcademyCompany.DAL.Model;
using System.ComponentModel.DataAnnotations;

namespace CodeAcademyCompany.PL.ViewModels
{
    public class DepartmentVM
    {


        public int Id { get; set; }
        [Required(ErrorMessage = "Code is Required for the Department")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name is Required for the Department")]
        public string Name { get; set; }

       

        //Navigational Property many
        ICollection<Employee> Employes { get; set; } = new HashSet<Employee>();
    }
}
