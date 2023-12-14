using MakeenPatch03_Day20.Models;
using MakeenPatch03_Day20.MyDbContext;

namespace MakeenPatch03_Day20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ClassWork
            /*
                 Create Employee Class and Convert it into a table 
                     EmployeeId , 
                     EmployeeName maxlength = 50 , 
                     EmployeeAge range between 18 to 50
                     EmployeeSalary --> Currency  

              */
            /*
                Department Class 
                -----------------
                DepId ==> primaryKey and Auto Incremental 
                Department name ==> maxlength 50 , minimum length 15
                dep floor ==> range 1 to 5
             
             
             */
            #endregion
            #region Adding to Database

            //ApplicationDbContext _db = new ApplicationDbContext();
            //int x = 5; 
            //while (x-->0)
            //{
            //    Console.WriteLine("ENTER YOUR NAME : ");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("ENTER YOUR address : ");
            //    string address = Console.ReadLine();
            //    Console.WriteLine("ENTER YOUR age : ");
            //    int age = int.Parse(Console.ReadLine()); 
            //    Console.WriteLine("ENTER YOUR NAME : ");
            //    decimal salary = decimal.Parse(Console.ReadLine());
            //    Employee emp = new Employee
            //    {
            //        Name = name,
            //        Salary = salary,
            //        Age = age,
            //        Adrress = address
            //    };

            //    _db.Employees.Add(emp);
            //    _db.SaveChanges();

            //}
            //Employee emp = new Employee
            //{
            //    Name = "adel",
            //    Salary = 200000000,
            //    Age = 23,
            //    Adrress = "alexandria"
            //};

            //_db.Add(emp);
            //_db.SaveChanges(); 
            #endregion


            #region Adding to Database using Try Finally 
            //try
            //{
            //ApplicationDbContext context = new ApplicationDbContext();
            //Employee employee = new Employee() { Name = "Ahmed", Adrress = "Alexadnria", Age = 23, Salary = 55555555 };
            //Employee employee1 = new Employee() { Name = "7oda", Adrress = "Karmoz", Age = 25, Salary = 33333333 };
            ////Locally 
            //context.Employees.Add(employee);
            //context.Employees.Add(employee1);
            ////Save Chnages happened Locally 
            //context.SaveChanges();
            //}
            //finally
            //{
            // used to terminated the unused Resources 
            //context.Dispose();

            //}
            #endregion

            // Close the Connection 


            #region Using Block
            //using (ApplicationDbContext context = new ApplicationDbContext() )
            //{
            //    Employee employee = new Employee() { Name = "Ahmed", Adrress = "Alexadnria", Age = 23, Salary = 55555555 };
            //    Employee employee1 = new Employee() { Name = "7oda", Adrress = "Karmoz", Age = 25, Salary = 33333333 };
            //    //Locally 
            //    context.Employees.Add(employee);
            //    context.Employees.Add(employee1);
            //    //Save Chnages happened Locally 
            //    context.SaveChanges();
            //} 
            #endregion

            #region Using Keyword Only 
            //using ApplicationDbContext context = new ApplicationDbContext();
            //Employee employee = new Employee() { Name = "Ahmed", Adrress = "Alexadnria", Age = 23, Salary = 55555555 };
            //Employee employee1 = new Employee() { Name = "7oda", Adrress = "Karmoz", Age = 25, Salary = 33333333 };
            ////Locally 
            ////context.Employees.Add(employee);
            ////context.Employees.Add(employee1);
            //////Save Chnages happened Locally 
            ////context.SaveChanges();
            //Console.WriteLine(employee.EmployeeID);
            //Console.WriteLine(employee1.EmployeeID); 
            #endregion

            //Console.WriteLine("Please ente the Id of the Employee you want to update ");
            //int id = int.Parse(Console.ReadLine());

            #region Updateing
            //using  ApplicationDbContext context = new ApplicationDbContext();
            //var emp = (from E in context.Employees
            //          where E.EmployeeID == 1 
            //          select E).FirstOrDefault();
            //emp.Name = "Mahmoud";
            //context.Employees.Update(emp);
            //context.SaveChanges();
            //Console.WriteLine(emp?.Name ?? "NA"); 
            #endregion

//            Employee employee = new Employee() { 
//            Name= "AHMED" , 
//            Age = 
//}; 

//            Employee.department.name

        }
    }
}