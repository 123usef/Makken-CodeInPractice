namespace MakeenPatch03_Day13_CashierVersion_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Cashier c1 = new Cashier(new MasterCard());
            Cashier c2 = new Cashier(new Cash());
            c1.checkout(3250m);
            c2.checkout(3250m);


        }

    }
}