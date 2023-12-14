using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenPatch03_Day15
{
    internal class Report
    {
        public void GreaterThan60K(Employee[] emp)
        {
            Console.WriteLine("Fliteration Process for Total Sales more Than 60 k ");
            Console.WriteLine("----------------------------------------------------");
            foreach (Employee e in emp)
            {   if (e.TotalSales >= 60000m)
                {
                    Console.WriteLine($"{e.Name} || {e.Gender} || {e.TotalSales}");
                }
             }
            Console.WriteLine("\n \n");
        }
        public void GreaterThan30KandLessThan60(Employee[] emp)
        {
            Console.WriteLine("Fliteration Process for Total Sales GreaterThan 30K and LessThan 60 ");
            Console.WriteLine("----------------------------------------------------");
            foreach (Employee e in emp)
            {
                if ( e.TotalSales >= 30000m & e.TotalSales < 60000m)
                {
                    Console.WriteLine($"{e.Name} || {e.Gender} || {e.TotalSales}");
                }
            }
            Console.WriteLine("\n \n");
        }
        public void Lessthan30K(Employee[] emp)
        {
            Console.WriteLine("Fliteration Process for Total Sales Lessthan 30K ");
            Console.WriteLine("----------------------------------------------------");
            foreach (Employee e in emp)
            {
                if (e.TotalSales < 30000m)
                {
                    Console.WriteLine($"{e.Name} || {e.Gender} || {e.TotalSales}");
                }
            }
            Console.WriteLine("\n \n");
        }

        // Common Factor ==> i will take the title inside the Parameter and the logic 
        // how i wiull take the logic ==> (wiht the Delegate )
        // delegate Decleration
        public delegate bool SalesFilterCondition(Employee emp);
        public void FilterEmployee(Employee[] emp , string Title , SalesFilterCondition cond)
        {
            Console.WriteLine(Title);
            Console.WriteLine("----------------------------------------------------");
            foreach (Employee e in emp)
            {
                if (cond(e))
                {
                    Console.WriteLine($"{e.Name} || {e.Gender} || {e.TotalSales}");
                }
            }
            Console.WriteLine("\n \n");

        }

    }
}
