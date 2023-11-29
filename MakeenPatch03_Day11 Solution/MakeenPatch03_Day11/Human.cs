using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MakeenPatch03_Day11
{
    internal class Human
    {
        //Default access Modifier for Class Members (Class Properties ) is : Private      
        private static int cnt;
        private int id; 
        private string name;
        private int age;
        private string address;
        private string Email;

        public int Age
        {
            //set { this.age = value; }
            get { return this.age; }
        }
        //public int socialInsuranceNumber { get;sets}
        public Human() { } // empty Constructor
        public Human(string name, int age, string address, string Email)
        {
            // what happens inside a function stay inside a function 
            cnt += 1;
            this.id = cnt;
            this.name = name;
            //this.age = ValidateAge(age) ? age : 0;
            this.age = age;
            this.address = address;
            this.Email = Email;
        }
        // string Concatination 
        //public string greetingbyname() => this.name + "\n " + "your email address is :" + this.Email;
        // string interpolation 
        public string greetingbyname() => $"{this.name}  \n   your email address is : {this.Email} \n your age is {this.age}";
        public static bool ValidateAge(int age)
        {
            if (age <= 0 || age >= 100)
            {
                return false;
            }
            return true;
        }

        //    // prototype 
        //    public static void Calculate(int x , int y , out int sum , out int multi)
        //    {
        //        sum = x + y;
        //        multi = x * y;
        //    } 

        //public int GetId()
        //{
        //    return this.id;
        //}
        //public void SetID(int ID)
        //{
        //    this.id = id;
        //}
        // body Expression Method 
        //public void SetId(int id) => this.id = id;
        public int GetID() => this.id;

        public string SetEmail(string email) => this.Email = email;
        public string GetEmail() => this.Email;

    }
    
}
