using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenPatch03_Day13_CashierVersion_
{
    internal class Cash : Ipayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"you have Paid the amount {amount} with Cash ");
        }
    }
    internal class Debit :Ipayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"you have Paid the amount {amount} with Debit Card ");
        }
    }
    internal class Visa : Ipayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"you have Paid the amount {amount} with Visa card ");
        }
    }
    internal class MasterCard : Ipayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"you have Paid the amount {amount} with MasterCard ");
        }
    }
}
