namespace MakeenPatch03_Day18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicit Type Variable 
            //Implicit Type Variables 
            // 2 types of implicit Type Variables 
            // Var KeyWord 
            // Var detect the Variable type in Compilation time 
            // var Must Be Initialized with Value 
            // var is Mutable Type(Can not be Changed when Declared ) 
            //int x ;
            //var y = 10;
            ////var z; Cannot do this 
            //y = 20;
            ////y = null;
            ////var list  = new List<int>();
            ////----------------------------------
            ////dynamic key word 
            ////dynamic is decleraed at the Runtime 
            //// Can Be Initialized without a value 
            //// not mutable (can assign Different Types )
            //dynamic dyn;
            //dynamic dyn1 = 10;
            //dyn = "string";
            //dyn = true;
            //dyn = new DateTime(); 
            #endregion

            #region Extension Method 
            //int x = 12345;
            //Console.WriteLine(IntegerMirror.Miror(x));
            ////Console.WriteLine(int.Miror(x));
            //Console.WriteLine(x.Miror());
            //int y = 54789;
            //Console.WriteLine(y.Miror());

            ////x.CompareTo(0); 
            #endregion

            #region Anonymous Type
            //// Anonymous Type 
            //var emp = new { id = 1, Name = "yousif", Salary = 120 };
            //var emp1 = new { Name = "Ahmed", Salary = 320 };
            //var emp3 = emp with { Salary = 3000} ;
            //Console.WriteLine(emp.GetType());
            //Console.WriteLine(emp1.GetType());
            //Console.WriteLine(emp3.Salary); 
            #endregion

            #region Linq Syntax
            //List<int> lst = new List<int> {1,2,3,4,5,6,7,8,9 };
            ////var result = Enumerable.Where(lst, x => x == 1 ).ToList();
            //List<int> result = Enumerable.Where(lst, x => x % 2 == 0).ToList();
            //List<int> result1 = lst.Where( x => x % 2 == 0).ToList();

            //// sql Querying 
            //var result3 = from i in lst
            //              where i % 2 == 0
            //              select i;


            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}

            //foreach (var x in result3.ToList())
            //{
            //    Console.WriteLine(x);
            //}

            //Console.WriteLine(result.GetType()); 
            #endregion

           List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9};
           var lst = numbers.Where(i => i % 2 == 0).ToList();
           numbers.Remove(2);
           numbers.AddRange(new int[] {10,11,12,13,14,15 });
            foreach (var item in lst.ToList())
            {
                Console.Write($"{item} ,");
            }
            numbers.Remove(2);

        }
    }
}