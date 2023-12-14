using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenPatch03_Day13_CashierVersion_
{
    interface Ipayment
    {
        void Pay(decimal amount);
    }
    internal class Cashier
    {
        public Ipayment payment;
        public Cashier(Ipayment payment)
        {
            this.payment = payment;    
        }

        public void checkout(decimal amount)
        {
            payment.Pay(amount);
        }
    }
}
