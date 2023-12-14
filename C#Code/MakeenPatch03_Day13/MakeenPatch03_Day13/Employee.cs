using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenPatch03_Day13
{
    sealed class Employee : People
    {
        // by Default inside the Class is Private
        string role;
        int WorkingHours;
        double wage;

        public Employee()
        {
            
        }
        public Employee(int Id, string Name, int Age, int SSN, string Address , string role , int WorkingHours , double wage):base( Id,  Name,  Age,  SSN, Address)
        {
            this.role = role;
            this.WorkingHours = WorkingHours;
            this.wage = wage;
        }

        //public void PrinbtInfo()
        //{
        //    Console.WriteLine($"hello mr {this.Name} your Position is {this.role} ");
        //}
        public override string ToString()
        {
            return base.ToString() + $"your position is {this.role}";
            //return $"hello mr {this.Name} your position is {this.role} ";
        }
        public override void CalculateSalary()
        {
            //base.CalculateSalary();
            Console.WriteLine($" your Total Salary is : {this.WorkingHours * this.wage}");
        }

    }
}
