
using System.ComponentModel;

namespace Day06_Patch03
{
    class Program
    {
        // Class Member Function : Class is the Owner (class can  Control ||)
        //static DataType FinctionName(Arguments or Parameters)
        //{
        //    logic Kobayt el shai
        //    return something from the same Datatype 
        //}
        //static void (Notype) FinctionName(Arguments or Parameters)
        //{
        //    logic Kobayt el shai
        //    opertation
        //    Console.wrtiteline() ; 
        //}

        //Static Function in Behaviour 
        //static void PrintLine()
        //{
        //    Console.WriteLine("---------------");
        //}
        // n =5 ==> n=9
        /*
         *                       default Values for Function 
         static void PrintLine(int n = 10 , string Pattern = "_")
         {
             for(int i = 0; i < n; i++)
             {
                 Console.Write(Pattern);

             }
             Console.WriteLine();
         }
        */
        #region Function with Default Parameters 
        ///static void PrintLine(string Pattern, int n = 10 )
        ///{
        ///    for (int i = 0; i < n; i++)
        ///    {
        ///        Console.Write(Pattern);
        //


        ///    }
        ///    Console.WriteLine();
        ///}
        ///
        #endregion

        //Employee emp = new Employee();



        //emp.FirstName = "Yousif 
        #region Summation and Multiplication 

        //static int Sum(int x, int y)
        //{
        //    //Console.WriteLine("hello world ");
        //    //      mathimatical operation 
        //    return x + y;
        //    //return x * y; un reachable Code Detected 
        //}
        //static int Multiplication(int x , int y ) {
        //    return x * y;
        //}
        #endregion

        // Passing Parameters by Value
        //static void Swap( int x,int y)
        //{
        //    Console.WriteLine($"Original Values  {x} , {y}");
        //    int temp = x; // take the X value into Temp              
        //    x = y; // replace x Value with Y Value 
        //    y = temp; // replace y Value with Temp Value (old X)
        //    Console.WriteLine($"Swapped Successfully {x} , {y}");
        //}

        #region Swap By Refrence 

        //static void Swap(ref int x ,ref int y)
        //{
        //    Console.WriteLine($"Original Values  {x} , {y}");
        //    int temp = x; // take the X value into Temp              
        //    x = y; // replace x Value with Y Value 
        //    y = temp; // replace y Value with Temp Value (old X)
        //    Console.WriteLine($"Swapped Successfully {x} , {y}");
        //}
        #endregion


        #region String By Ref 
        // String Ebn el bata el byda 
        //static void AddWorld(ref string s)
        //{
        //    s += " world";
        //}
        //object Parent of all Datatypes 
        // has common 4 methods that shared between all data types 
        //Tostring(_
        #endregion
        #region Is Updated Function For Array Refrence Type 

        //static void isUpdated(int[] arr)
        //{
        //    arr[0] = 100; 

        //}
        //static void isUpdated(ref int[] arr)
        //{
        //    arr[0] = 100;

        //}
        #endregion

        //static bool  Calculations( int  x ,  int y , ref int sum , ref int multiplication)
        //{
        //     sum = x + y;
        //     multiplication = x * y;

        //    return true ;

        //}
        static bool Calculations(int x, int y, out int sum, out int multiplication)
        {
            sum = x + y;
            multiplication = x * y;

            return true;

        }
        static bool TryParseCustomized(string s , out int x)
        {
            x = 0;
            bool flag = false;
            try
            {
                    x = int.Parse(s);
                    flag = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("hello from Customized Try Parse");
            return flag;
        }
        static void Main(string[] args) /*startup Function*/
        {

            #region PrintLineFunction With Different Calling Types
            //Console.WriteLine("-------------------");

            //PrintLine();
            //PrintLine();
            //PrintLine();
            // PrintLine( Pattern:"*__*" ,n: 2);
            //PrintLine(9);
            //PrintLine(10, "*");
            //PrintLine(16, "-");
            //PrintLine();
            //PrintLine("$--$");
            #endregion
            #region Calling Summation and Multiplication 
            //int result = Sum(1, 2);
            //int result2 = Multiplication(Sum(1,3), 2);

            //Console.WriteLine($"summation is   {result}");
            //Console.WriteLine($"Multiplication of the Summation  is   {result2}");

            //Console.WriteLine();

            //Console.WriteLine(Sum(1, 2));
            #endregion
            #region Swap Integer
            //int a = 3, b = 10;
            //Calling Swap By passing Values 
            //Swap(a, b);
            //Calling Swap by Passing Refrence 
            //Swap(ref a, ref b);
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine($"A value is {a} , B Value is {b}");
            #endregion

            #region Refrence Types String
            //object obj1 =new object();
            //object obj2 =new object();
            //Console.WriteLine(obj1.GetHashCode());
            //Console.WriteLine(obj2.GetHashCode());
            //obj1 = obj2; // address = address  
            //Console.WriteLine(obj1.GetHashCode());
            //Console.WriteLine(obj2.GetHashCode());
            //string s = "Hello";

            //AddWorld(ref s);
            //Console.WriteLine(s); // Hello =>6 || Hello World ==>5 
            #endregion

            #region REFRENCE tYPE pASSING BY vALUE AND REF  
            //int[] numbers = { 1, 2, 3, 4, 5, 6, };
            //Console.WriteLine(numbers[0]); //1
            ////isUpdated(numbers);
            //isUpdated(ref numbers);
            //Console.WriteLine(numbers[0]); // 1 || 100
            #endregion
            //int a = 6, b = 5;
            ////int sm , ml ;
            //Calculations(a, b, out int sm, out int  ml);
            //Console.WriteLine($"summation is {sm} , multiplication is {ml}");
            TryParseCustomized("3a" ,  out int x );
            Console.WriteLine(x);
        }
    }
}




/*
    Create Class Member Function that Takes From the User 3 Parameters
    Pattern , LengthOfPattern , Flag 
    Pattern Should Be Printed on the SameLine with length (LengthofPattern)
    if the Flag is True you Should BreakLine After Finishing the Pattern 
    If Not don't Break Line 
    Call the Function inside the Main Twice once with Flag True and One 
    with Flag False

*/