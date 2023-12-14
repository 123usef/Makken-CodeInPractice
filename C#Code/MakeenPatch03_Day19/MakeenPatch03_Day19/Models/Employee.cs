using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenPatch03_Day19.Models
{
    // By Convention 
    internal class Employee
    {
        public int Id { get; set; } // numeric Representitive Id || EmployeeId ==> Primary Key
        public string Name { get; set; } // nVarChar(max) || accept null 
        public decimal salary { get; set; }  // Dosent Accept Null 
        public int? Age { get; set; } // accept Null  
    }
}
