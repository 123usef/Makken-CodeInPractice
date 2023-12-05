
namespace MakeenPatch03_Day14
{
    enum Gender
    {
        Male ,
        Female
    }

    enum Months
    {
        january = 1 , 
        febrauary ,
        march , 
        april , 
        may , 
        june , 
        july ,
        august ,
        septemper , 
        november ,
        december
    }


    [Flags]
    enum Permissions
    {
        None =  0, // 000000000 
        Read  = 1, //000000001 
        Write = 2,
        Delete = 4 , 
        Excute = 8
    }

    internal class Program
    {

        public static int simpleArraySum(List<int> ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                sum += ar[i];
            }
            return sum;

        }


        static void Main(string[] args)
        {
            #region Enums Practice
            //Months month = Months.january;
            //Console.WriteLine($" the Month is {month}  ==> {(int) month}");
            //Gender gen = Gender.Male;
            //Console.WriteLine((int)gen);

            //Console.WriteLine(month);

            //Permissions myPermission = Permissions.Read | Permissions.Write | Permissions.Excute;
            //Console.WriteLine(myPermission);


            #endregion

            //User user1 = new User("yousif", 26, 2550);
            //User user2 = new User("Adel", 25, 2000);
            //Console.WriteLine(user1);
            //Console.WriteLine(user2);
            //Console.WriteLine(user1 + user2);
            //Console.WriteLine(user1 - user2);


        }
    }
}