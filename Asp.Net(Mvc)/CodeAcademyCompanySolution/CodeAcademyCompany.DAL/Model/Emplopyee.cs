using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyCompany.DAL.Model
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        [MaxLength(50)]
        [MinLength(5)]
        public string Name { get; set; }
        
        [MaxLength(50)]
        [MinLength(4)]
        public string City { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Range(18,33)]
        public int age { get; set; }

        [DataType(DataType.Currency)]
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
