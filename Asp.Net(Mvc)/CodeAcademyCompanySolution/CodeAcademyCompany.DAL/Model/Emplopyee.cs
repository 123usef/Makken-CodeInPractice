using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    }
}
