using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenPatch03_Day14
{
    internal class User
    {
        //autoamtic Property 
        public string Name { get; set; }
        public int Age { get; set; }
        public double Money { get; set; }
        public User(string Name , int Age , double Money)
        {
            this.Name = Name;
            this.Age = Age;
            this.Money = Money;
        }

        // + Over Loading
        public static double operator + (User a, User b)
        {
            double result = a.Money + b.Money;
            return result;
        }
        public static double operator -(User a, User b)
        {
            double result = a.Money - b.Money;
            return result;
        }
        public static bool operator == (User a, User b)
        {   if(a.Money == b.Money)
            {
                return true;
            }
            
            return false;
        }
        public static bool operator !=(User a, User b)
        {
            if (a.Money == b.Money)
            {
                return false;
            }

            return true;
        }
    }
}
