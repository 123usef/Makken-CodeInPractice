
namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays 
            // // snigle Dimensional Array 
            // // from any Data type 
            // int n;
            // n = Convert.ToInt32(Console.ReadLine());
            //int[] arr1 = new int[n];
            // //يdont fROGET THAT array is Accessd by Index 
            // arr1[0] = 1;
            // arr1[1] = 2;
            // arr1[2] = 3;
            // arr1[3] = 4;
            // arr1[4] = 5;
            // //arr1[5] = 3; out of Bound Width (natet mn 3la el gabl ))
            // // Multi Dimensional Array
            // //  1,2,3,4,
            // //  5,6,8,7  ==> Matrix  
            // //  4, 5 ,6 
            // int[,] Grades = new int[2,3] ;
            // Grades[0, 0] = 1;
            // Grades[0, 1] = 2;
            // Grades[1, 0] = 1;
            // Grades[1, 1] = 1;

            // //Jagged array 
            // int[][] Employees = new int[2][];
            // Employees[0]= new int[3] { 1, 2, 3 };
            // Employees[1] = new int[2] { 1, 2};
            #endregion


            #region If Statment
            //if (value >= 75)
            //{
            //    Console.WriteLine("Succedd");
            //}
            //else if(value>=50)
            //{
            //    Console.WriteLine("Failed");
            //}
            //else
            //{
            //    Console.WriteLine("inclaid input Out OF range ");
            //}
            #endregion

            //Console.WriteLine("Hello please enter Student Grade !! ");
            #region Problem Cafe

            /*
            //                  0           1           2
            
            string[] menu = { "Lattte", "Cappcino", "amreicano" };
            double[] Prices = { 3.65, 2.35, 4};
            string[] Sizes = { "Small" ,"Medium" ,"Large"  };
            
            //double [] Prices = new int[3]{ 3.65, 2.35, 4};
            Console.WriteLine("Menu :");
            Console.WriteLine($"1.{menu[0]} -- {Prices[0]}$");
            Console.WriteLine($"2.{menu[1]} -- {Prices[1]}$");
            Console.WriteLine($"3.{menu[2]} -- {Prices[2]}$");
            Console.WriteLine("Please enter the desired Drink from (1-3)");
            int value = Convert.ToInt32(Console.ReadLine());
            
            string Drink  ;
            double price ;
            string size;
            string MilkValue;
            string SugarValue;

            Drink = menu[value - 1];
            price = Prices[value - 1];
            Console.WriteLine("Choose the Size of the drink : \n 1.Small \n 2.Medium \n 3.Large \n \t Please choose the Size from (1-3) ");
            int userValue = Convert.ToInt32(Console.ReadLine());
            size = Sizes[userValue - 1];
            Console.WriteLine("Do You it with Milk :(Yes -NO) :");
            string val = Console.ReadLine();
            MilkValue = (val.ToLower() == "yes") ? "With Milk " : "Without Milk ";
            Console.WriteLine("Do You it with Sugar :(Yes -NO) :");
            val = Console.ReadLine();
            SugarValue = (val.ToLower() == "yes") ? "With Sugar" : "Without Sugar ";
            Console.WriteLine("******************************************");
            Console.WriteLine("\t\t\t\t\t Checkout ");
            Console.WriteLine($"your Drink is : {Drink} \n with Size : {size} , {SugarValue} , {MilkValue} \n Total Price is : {price}");

            Console.WriteLine("******************************************");
            */
            #endregion


            #region Lecture Example 
            //Console.WriteLine("Welcome to our Simple Calculator : ");
            //Console.WriteLine("What type of Operations do you need ");
            //Console.WriteLine("1. Summation \n 2.Subtraction  \n 3.Multiplication \n 4.Division \n\t 0.for exit \n \t\t enter numaric Value");
            //int value = Convert.ToInt32(Console.ReadLine());
            //if (value == 0)
            //{
            //    Console.WriteLine("Thanke For Trusting our Logic ");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter the first number");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Please enter the Second number");
            //    int b = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region Switch
            //    switch (value)
            //    {
            //        case 1:

            //            Console.WriteLine($"summation of {a} + {b} = {a + b}");

            //            break;
            //        case 2:
            //            Console.WriteLine($"subtraction of {a} - {b} = {a - b}");
            //            break;

            //        case 3:
            //            Console.WriteLine($"Multiplication of {a} * {b} = {a * b}");
            //            break;
            //        case 4:
            //            Console.WriteLine($"Divvision of {a} / {b} = {a / b}");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid inpur");
            //            break;


            //    }
            //}
            #endregion

            



        }
    }
}