namespace MakeenPatch03_Day11
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Part 1
            //Console.WriteLine("Welcome to OUR System Please enter the Following Info to singup ");

            //Console.WriteLine("enter your name : ");
            //string name = Console.ReadLine();

            //Console.WriteLine("enter your Age : ");
            //string sage;
            ////int age;
            //do
            //{
            //    int y = 3;
            //    sage = Console.ReadLine();
            //} while (int.TryParse(sage, out int age) && (age < 0  || age>=100));

            //Console.WriteLine("enter your address : ");
            //string addr = Console.ReadLine();

            //Console.WriteLine("enter your Email : ");
            //string Email = Console.ReadLine();

            //Human human = new Human(name ,age, addr ,Email) ;

            //Console.WriteLine(human.greetingbyname());

            //Human human1 = new Human("Mohamed el Abri", 25, "Muscat ,Oman", "MohamedAlAbri123@gmail.com");
            //Console.WriteLine(human1.greetingbyname());
            //Human human2 = new Human { name = "yousif", age = 26 ,address = "alexandria egypt"};
            //Human human3 = new Human ( name : "yousif", age: 26 , address : "alexandria egypt" ,Email :"ddd" );
            //Console.WriteLine(human3.name);
            //human3.name = "ahmed";
            //Console.WriteLine(human3.name);
            #endregion

            Employee employee = new Employee("yousif" , "mohamed" , 26 , "Muscat");
            Console.WriteLine(employee.GetFname());
            //employee.SetFname("ahmed");
            Console.WriteLine(employee.GetFname());
            Human h1 = new Human
            {
                name = "yousif",
                address = "alex",
                Age = 26 

            };
            h1.SetEmail("yuousif@gmail.com");
            Console.WriteLine(h1.GetEmail());
            Console.WriteLine(h1.GetID());

        }
    }
}