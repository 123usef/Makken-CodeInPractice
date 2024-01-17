using CodeAcademyCompany.DAL.Model;
using System.ComponentModel.DataAnnotations;

namespace CodeAcademyCompany.PL.ViewModels
{
    public class EmployeeVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [MinLength(5)]
        public string Name { get; set; }

       
        [MinLength(4)]
        public string City { get; set; }

        [EmailAddress]

        //[RegularExpression()]
        public string Email { get; set; }

       
        public string? ImageUrl { get; set; }
        public IFormFile Image { get; set; }

        [Range(18, 33)]
        public int age { get; set; }

        public decimal Salary { get; set; }

        //[ForeignKey("Department")]

        public int? DepartmentId { get; set; } // restricted

        //Navigational Property of type one
        // OnDelete ==> Cascade == > remove the relationed Data
        //          ==> Restrict ==>  no remove for the princible Data
        //          ==> SetNull ==> set Null for the Deleted Attribute 
        //==> DoNothing 

        public Department Department { get; set; }
    }
}
