using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenPatch03_Day20.Models
{       // by Data Annotations
    internal class Department
    {

        [Key] // Primary Key ==> not auto Increamnted 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int depId { get; set; }

        [Required]
        [MaxLength(80)]
        [StringLength(80 , MinimumLength =10)]

        public string Name { get; set; }
        //[Phone]
        [DataType(DataType.PhoneNumber)]
        public long PhoneNumber { get; set; }
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Range(1,4)]
        public int Floor { get; set; }
        public List<Employee> employeees { get; set; }
    }
}
