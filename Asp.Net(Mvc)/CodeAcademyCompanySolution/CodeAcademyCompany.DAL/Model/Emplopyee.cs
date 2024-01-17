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

        
        [MaxLength(50)] 
        public string Name { get; set; }
        
        [MaxLength(50)]
        
        public string City { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string? ImageUrl { get; set; }

        public int age { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

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
