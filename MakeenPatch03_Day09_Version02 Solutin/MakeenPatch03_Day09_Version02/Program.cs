namespace MakeenPatch03_Day09_Version02
{   
   

     class Program
    {
        static decimal CalculateNetSalary(int loggedHours , int Wage)
        {   // Fractions Casting  ==> Double by Default 
            //                        float ==> xxf
            //                        decimal ==> xxm    
            int TotalSalary = loggedHours * Wage;
            decimal taxCalculated =  TotalSalary * 0.3m ;
            return  TotalSalary - taxCalculated;

        }
        static void Main(string[] args)
        {
            Employee emp1 = new Employee( "usif","mohamed" ,  26);
            Employee emp2 = new Employee( "ahmed","mohamed" ,  36);
            Employee emp3 = new Employee( "mahmoud","mohamed" ,  42);
            Employee emp4 = new Employee();
            Employee[] employees = { emp1, emp2, emp3 };
            //foreach (Employee emp in employees)
            //{
                
            //Console.WriteLine($"{emp.FName} , {emp.LName}");
            //}
            Console.WriteLine("Hello to Our System ");
            emp1.id = 1;
            Console.WriteLine("Please Enter employee First Name  ");
            emp1.FName = Console.ReadLine();

            Console.WriteLine("Please Enter employee Last Name  ");
            emp1.LName = Console.ReadLine();

            Console.WriteLine("Please enter your Age  :");
            emp1.age = int.Parse(Console.ReadLine()) ;

            Console.WriteLine("please Enter your Logged Hours  : ");
            int LoggedHours  = int.Parse(Console.ReadLine());

            Console.WriteLine("please Enter your Wage (price per Hour) : ");
            int wage = int.Parse(Console.ReadLine());
            emp1.Salary = CalculateNetSalary(LoggedHours, wage);

            Console.WriteLine($"hello emp : {emp1.LName} \n welcome On Board \n" +
                $"your net Salary is {emp1.Salary} and thats after cutting Taxes by 3%");



        }
    }
}