
namespace MakeenPatch03_Day09_Version02
{
     class Employee
    {
        //Class Members 
        //<access Modifier><DataType><Variable Name>
        public      int           id = 0;
        public string FName;
        public string LName;
        public int age;
        public decimal Salary;

        public Employee()
        {
            //c# Team by Deafult inside any Class has Prepared 
            // Empty Constructor 
            Console.WriteLine("hello from no Values ");
        }
        //public Employee(decimal Salary)
        //{
        //    this.Salary = Salary;
        //}

        public Employee( string _FName, string _lName, int _age  )
        {
            id +=1 ;
            FName = _FName;
            LName = _lName;
            age = _age;

            Console.WriteLine($"emp with id {id} is Created ");

        }


        


    }
}
