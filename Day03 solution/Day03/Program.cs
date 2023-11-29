namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Refrencing 
            //string s1 = "hello there";
            //string s2 = s1;
            //s1 = "Joonguini ";
            //Console.WriteLine($"s1 value  : {s1} \ns2 value is : {s2}");
            //// 0x3fc21 ==> memory address in hexadecimal 
            //Console.WriteLine("s1 place  :" + s1.GetHashCode());

            //Console.WriteLine("s2 value  :" + s2);
            //Console.WriteLine("s2 place  :" + s2.GetHashCode());  
            #endregion

            //int x = 1;

            // postfix -->  ba3d el 5atwa 
            //-------------------------------
            //Console.WriteLine(x++); // res ==> 1 
            //Console.WriteLine(x); // res ==> 2

            //x++; //==? increment 
            //Console.WriteLine(x); //res ==>  2
            //------------------------------
            //Console.WriteLine(++x); // res ==> 1 || 2
            //Console.WriteLine(x); // res ==> 1 || 2 
            //++x;
            //Console.WriteLine(x); 
            int x = 1;
            int y = 2;

            Console.WriteLine((++x) + y); // 3 || 4

        }
    }
}