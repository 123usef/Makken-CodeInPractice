using System.Security.Cryptography.X509Certificates;

namespace MakeenPatch03_Day15
{
    internal class Program
    {
        //public static void Print(int x)
        //{
        //    Console.WriteLine(x);
        //}
        //                       int int || string || bool        
        public static void Print<T>(T Val)
        {
            Console.WriteLine(typeof(T));
            Console.WriteLine(Val);

        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            #region Delegates 
            //Employee[] emp = new Employee[]
            //   {
            //    new Employee {id=1 , Name="yousif" , Gender= "male" , TotalSales = 35000m},
            //    new Employee {id=2 , Name="Mohamed" , Gender= "male" , TotalSales = 75000m},
            //    new Employee {id=3 , Name="Nader" , Gender= "male" , TotalSales = 20000m},
            //    new Employee {id=4 , Name="Abdelmageed" , Gender= "male" , TotalSales = 18000m},
            //    new Employee {id=5 , Name="Salem" , Gender= "male" , TotalSales = 45000m},
            //    new Employee {id=6 , Name="Alaa" , Gender= "female" , TotalSales = 80000m},
            //    new Employee {id=7 , Name="Mary" , Gender= "female" , TotalSales = 9000m},


            //   };
            //Report rep = new Report();
            //rep.GreaterThan60K(emp);
            //rep.GreaterThan30KandLessThan60(emp);
            //rep.Lessthan30K(emp);
            ////----------------------------------
            //bool Greater60k(Employee emp) => emp.TotalSales >= 60000m;
            //bool Ibetween60kto30k(Employee emp) => emp.TotalSales >= 30000m & emp.TotalSales < 60000m;
            //bool lessThan30k(Employee emp) => emp.TotalSales < 30000m;
            //rep.FilterEmployee(emp, "total SALES Greter than 60k", Greater60k);
            //rep.FilterEmployee(emp, "total SALEs Between  60k to 30k", Ibetween60kto30k);
            //rep.FilterEmployee(emp, "total SALEs Lessthan  30k", lessThan30k);
            //rep.FilterEmployee(emp, "total SALEs less than 10000", (emp) => emp.TotalSales < 10000m);
            //rep.FilterEmployee(emp, "Females Employees only ", (emp) => emp.Gender == "female");

            #endregion

            //Print(3);
            //Print("yousif");
            //Print(true);
            //Print(3.2);
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(list);
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Display();

        }
    }
}