using System.Threading.Channels;

namespace Day07_Patch03
{
    enum Grades : byte
    {
        a=1, b, c, d=15, e=255, f 
    }

    class Program
    {
        
        
        #region SumVersion2 Function 

        //static bool SumVersion2(int a , int b ,out int Multiplication , out int sum , params int[] z)
        //{
        //    if (z.Length > 1)
        //    {
        //        Multiplication = a * b;

        //        sum = 0;
        //        for (int i = 0; i < z.Length; i++)
        //        {
        //            sum += z[i];
        //        }
        //        return true;
        //    }
        //    else
        //    {
        //        Multiplication = 0;
        //        sum = 0;
        //        return false;
        //    }

        //}
        #endregion

        #region Param Function
        //static int SumArray(int x,int y=3 ,params int[] arr )
        //{
        //    int sum = 0;
        //                //      arr.Length 
        //    for (int i = 0; i < arr.Length ; i++)
        //    {   // Sum of Elements 
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        #endregion
        static void DoSomething()
        {
            //int x , y;
            int y;
            
           
            Console.WriteLine("Please enter the First   Number : ");
            int x =  int.Parse(Console.ReadLine());
    

            //do
            //{
            //    Console.WriteLine("Please enter the First   Number : ");
            //} while (!int.TryParse(Console.ReadLine(), out  x));

            do
            {
                Console.WriteLine("Please enter the Second Number : ");
            } while (!int.TryParse(Console.ReadLine(), out y) || y==0);

            int z = x / y;

            int[] arr = { 1, 2, 3, 4, 5, 6, };
            if (arr.Length > 10)
            {
                Console.WriteLine(arr[10]);
            }


        }
        static void Main()
        {
            #region Parms to Function 
            //int[] Numbers = { 1, 2, 3, 4, 5 };
            ////Console.WriteLine(SumArray(Numbers));
            ////Console.WriteLine(SumArray( new int[] { 1,2,3,4,5}));
            //Console.WriteLine(SumArray(1,2,3,4,5));
            //bool flag = SumVersion2(1, 2,out int x , out int y,  3, 4, 5);
            //Console.WriteLine($"Multiplication is {x} \n summation is {y}");
            #endregion
            //Console.WriteLine("hello to my Program");

            //try
            //{
            //    DoSomething();
            //    Console.WriteLine("hello After Exceptionn "); //will not be Achivied
            //}
            //catch (Exception ex )
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("hello from other Side ");

            Grades grades = (Grades)1;
            Grades gradesb = (Grades)2;

            Console.WriteLine(grades);
            Console.WriteLine(gradesb);

        }
    }
}