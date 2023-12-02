namespace Makeen_Patch03_Day11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook MyPhone = new PhoneBook(5);
            
            #region PhoneBook Call 
            //MyPhone.addPerson( "Adel Mahmoud", 0111111111);
            //MyPhone.addPerson( "ahmed ali ", 01000000000);
            //MyPhone.GetAll();
            //Console.WriteLine(MyPhone.GetNumber("yousif mohamed"));

            //MyPhone.EditNumber("yousif momed" , 01206086290);
            //Console.WriteLine(MyPhone.GetNumber("yousif mohamed"));
            //Console.WriteLine(PhoneBook.cnt);

            // indexer Property 

            //MyPhone["yousif mohamed"] ==> number  ==> get 
            // myphone["yousif mohamed "]  = 0125468796 ;  ==> set  
            #endregion

            MyPhone.addPerson("yousif mohamed", 01212123265);
            Console.WriteLine(MyPhone["yousif mohamed"]);
            MyPhone["ahmed mohamed" ] = 0124567889;
            MyPhone["yousif mohamed", true] = 123456789;
            MyPhone.GetAll();

        }
    }
}