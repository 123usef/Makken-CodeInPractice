using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ProblemSolvingLec_Pacth3
{
    internal class Program
    {

        static string SolvingSumProblem()
        {
            int ArrSize, Target;
            //                  Characters not String 
            string s = Console.ReadLine();
            // " 3 4"
            // " 3" " 4 "
            string[] arr = s.Split(" ");
            ArrSize = int.Parse(arr[0]);
            Target = int.Parse(arr[1]);

            int[] Values = new int[ArrSize];
            //arr Values 
            // " 3 4 5 6 7 8 "
            s = Console.ReadLine();
            arr = s.Split(" ");
            for (int i = 0; i < ArrSize; i++)
            {
                Values[i] = int.Parse(arr[i]);
                //Console.WriteLine(Values[i]);
            }
            //Values
            bool flag = false;
            string Sol = "-1";
            for (int i = 0; i < Values.Length - 1; i++)
            {

                for (int J = i + 1; J < Values.Length; J++)
                {
                    if (Values[i] + Values[J] == Target)
                    {
                        //Sol = $"{i + 1} {J + 1}";
                        Sol = $"{Values[i]} {Values[J]}";
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }

            }
            return Sol;
        }

        static void MultiplicationTable(int n = 1)
        {
            string s = " ";
            for (int i = 1 ; i <= n ; i++){
                Console.WriteLine($"Multiplication Table for {i} ");
                for (int  j = 1 ; j <= 10 ; j++)
                {
                    //s += $" {i} * {j} = {i * j} \n";
                    Console.WriteLine($" {i} * {j} = {i * j}");

                }

                //s += "------------------------------"
                Console.WriteLine("--------------------------------");

            }
        }

        static string Sum2Numbers()
        {
            // Output will be Values not Indexies 
            //------------------------------------
            int ArrSize, Target;
            //                  Characters not String 
            string s = Console.ReadLine();
            // " 3 4"
            // " 3" " 4 "
            string[] arr = s.Split(" ");
            ArrSize = int.Parse(arr[0]);
            Target = int.Parse(arr[1]);

            int[] Values = new int[ArrSize];
            //arr Values 
            // " 3 4 5 6 7 8 "
            s = Console.ReadLine();
            arr = s.Split(" ");
            for (int i = 0; i < ArrSize; i++)
            {
                Values[i] = int.Parse(arr[i]);
                //Console.WriteLine(Values[i]);
            }


            Array.Sort(Values);// Ascindeing  Sorting 
                               //Array.Reverse(Values); //dESCINGINDG sORTING 
            int st = 0, end = ArrSize - 1; 
            while(st < end)
            {
                if (Values[st] + Values[end] == Target)
                {
                    return $"{Values[st]}  {Values[end]}";
                }
                else if(Values[st] + Values[end] < Target)
                {
                    st++;
                }
                else
                {
                    end--;
                }
            }

            return "-1";
        }


        //static int Sum1toN(int n)
        //{
        //    int sum = 0;
        //    for (int i = 1 ; i <= n; i++)
        //    {
        //        sum += i;
        //    }
        //    // Complexity : O(n) 
        //    return sum;
        //}
        //static int Sum1toNVersion2(int n)
        //{
        //    int sum = n * (n + 1) / 2;
        //    // Complexity : O(1) : Mathimatical Equation  
        //    return sum;
        //}


        static bool  IsPalindrome(int x)
        {
            string s = x.ToString();
            string revs = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i];
            }
            Console.WriteLine(revs);
            if (revs == s)
            {
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {


            Console.WriteLine(IsPalindrome(121));
            Console.WriteLine(IsPalindrome(-121));
            Console.WriteLine(IsPalindrome(10));

            // input Phase
            //Console.WriteLine(SolvingSumProblem()); 

            //MultiplicationTable(3);
            //
            //Stopwatch(MultiplicationTable(3));


            //MultiplicationTable();

            //---------------------------


            //Console.WriteLine(Sum1toN(5));
            //Console.WriteLine(Sum1toNVersion2(5));
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //MultiplicationTable();
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed);






        }
    }
}