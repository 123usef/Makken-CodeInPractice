using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenPatch03_Day20.Models
{
    // By Convention  :: بالاتفاق
    internal class Employee
    {
        public int EmployeeID { get; set; } // 
        //[Column(TypeName = "varchar")]
        public string  Name { get; set; } //   Default =>  Not Null 
        
        public decimal Salary { get; set; }

        public int Age { get; set; }
        public string? Adrress { get; set; }
        //public string? surName { get; set; }
        //[ForeignKey]
        //public int departmentid { get; set; }
        //[ForeignKey(name:"departmentid")]
        public Department depid { get; set; }

    }
}
