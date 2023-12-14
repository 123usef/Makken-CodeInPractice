
namespace MakeenPatch03_Day11
{
    internal class Employee
    {


        private string Fname;
        private string Lname;
        private int age;
        private string address;

        public Employee(string Fname , string Lname , int age , string address)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.age = age;
            this.address = address;
        }
        public string GetFname()
        {
            return this.Fname;
        }
        //public void SetFname(string Fname)
        //{
        //    this.Fname= Fname;
        //}

    }
}
