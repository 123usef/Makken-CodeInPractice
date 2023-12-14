namespace MakeenPatch3_Day09
{
    // class ,enum , interface , struct 
   
   // Refrence Datatype || Value  type
   // class interface   ||  struct   enum 
    class Employee
    {   // you have Created a هيكل 
       public  int id;
       public  string name;
        public  string address;
        public  int  age; 
        public decimal Salary;
    }
        
    internal class Program
    {
        
        //static bool IsPalindrome2(int x)
        //{
        //    string s = x.ToString(); // changed the Format from Int to String 
        //    int st = 0, end = s.Length - 1;
        //    while (st<= end)
        //    {
        //        if (s[st] != s[end])
        //        {
        //            return false;
        //        }
        //        st++;
        //        end --;
        //    }
        //    return true;
        //}

        //static bool IsPalindrome(int x)
        //{
        //    string s = x.ToString(); // changed the Format from Int to String 
        //    string revs = "";
        //    for (int i = s.Length -1 ; i >= 0 ; i--)
        //    {
        //        revs += s[i];
        //    }
        //    if(s == revs)
        //         return true;
            
        //    return false;
        //}

        static void Main(string[] args)
        {
            // Create Object or Instance from the Class 
            string[] arr = new string[3];
            String str = new string("hello world");
            string str1 = "hello world ";
            int[] nums = { 1, 2, 3, 4 };
            object obj  = new object();

            Employee emp =new Employee();
            emp.id = 1;
            emp.name = "yousif";
            emp.address = "Alexandria , Egypt ";
            emp.age = 26;
            emp.Salary = 2;
            Console.WriteLine($"hello Mr {emp.name} to Code Academy \n your age is {emp.age} \n with Salary {emp.Salary} OMR ");
            Employee emp2 = new Employee(); 
            emp2.id = 2;
            emp2.name = "Kulsoom";
            emp2.address = "muscat";
            emp2.age = 23;
            emp2.Salary = 3;
            Console.WriteLine($"hello Mr {emp2.name} to Code Academy \n " +
                $"your age is {emp2.age} \n with Salary {emp2.Salary} OMR ");

            Employee[] emparr = new Employee[2]{ emp, emp2 };
            //emparr[0].
            //Console.WriteLine(IsPalindrome2(121));
            //Console.WriteLine(IsPalindrome2(-121));
            //Console.WriteLine(IsPalindrome2(10));
            //Console.WriteLine(IsPalindrome2(1221));
            //Console.WriteLine("Hello, World!");
        }
    }
}