namespace Patch3_Day03
{
    class Program
    {
        static void Main()
        {

            #region Consoling Data
            //Console.WriteLine( "Hello, World! from c#  \n " +  
            //    "\t we are patch 3 in makeen \n" +
            //    "\t we are now learning c#");
            #endregion
            #region Value Types 
            // Value Datatypes 
            //string FirstName = "yousif mohamed" , fulltimejob = "software Developer";
            //string FullTimeJob = "Full Stack instructor";
            //string PartTimeJob = "busniess Developer";
            //int age; // Variable Decleration 
            //age = 26;
            //Console.WriteLine("First name :" + FirstName + "\n my age is :" + age);
            //Console.WriteLine("Job :" + FullTimeJob);
            //age = 25; 
            //Console.WriteLine(age);
            //age = 28;
            #endregion
            #region
            //int number_Of_Days = 80;
            //long ssn = number_Of_Days;
            //int x = (int)ssn;
            ////-----------------------------------
            //long suv = 123456786455460;
            //checked
            //{

            //   int update = (int)suv;
            //    unchecked
            //    {

            //    }
            //}
            //Console.WriteLine(update);

            // Decimal
            //double payment = 55.7;
            //float money = 3.45f;
            //decimal salary = 4.5m;
            //Console.WriteLine(ssn);
            //int realPayment = (int)payment;
            //Console.WriteLine(realPayment);

            #endregion

            //int x = 5;
            //int y = x; 
            //Console.WriteLine(y);
            //x = 7;
            //Console.WriteLine(y);

            //string Greeting = "Hello World";
            //string cpGr = Greeting;
            //Console.WriteLine(cpGr);
            //Greeting = "Yalhwi";
            //Console.WriteLine(cpGr);

            Object obj1 = new Object();// hascode 43942917
            Object obj2 = new Object();// hash code 59941933 
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
            Console.WriteLine("----------------OLD-----");
            obj2 = obj1;
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());


        }
    }
        #region Comments and keys
        //one line Comment 
        // hig dip;oma student and the extra futres done by Dynamic Programming
        /*  
         *  Multi Line Comment
         *  for Commenting Section in Visual Studio Code 
         *  ctrl + k + c ==> this will comment (k ==> make ::: c ==> Comment)
         *  ctrl + k + u ==> this will uncomment (k ==> make ::: u ==> unComment)
         */
        #endregion
        #region Class implmentation
        //class Student
        //{
        //    public int Id { get; set; }
        //}
        #endregion
}