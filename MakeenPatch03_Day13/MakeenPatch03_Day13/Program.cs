namespace MakeenPatch03_Day13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Abstract Keyword doesn't allow for you to Create an Object from the Class 
            //People P1 = new People(1, "Yousif", 26, 1345778, "alexandria");
            Employee emp = new Employee(1,"Yousif" , 26 , 1345778 , "alexandria" , "Full Stack Instructor" , 167 , 10.5);
            //emp.PrinbtInfo();

            Console.WriteLine(emp);
            Console.WriteLine(emp.ToString());
            emp.CalculateSalary();
            emp.Move

            object obj = new object();
        }
    }
}