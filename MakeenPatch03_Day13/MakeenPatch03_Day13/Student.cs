using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenPatch03_Day13
{
    internal class Student : People
    {
        public int AbsenceDay;
        public int wage;

        public override void CalculateSalary()
        {
            base.CalculateSalary();
            Console.WriteLine($"your total salary is Calculated According to {(30-AbsenceDay) * 5 }");
        }
    }
}
