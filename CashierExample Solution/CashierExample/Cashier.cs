using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierExample
{
    internal class Cashier
    {
        // Class Members
        #region yarasi implementation
        //public Cash ch;
        //public VisaCard vs;
        //public MasterCard ms;
        //public Debit db;
        //public Cashier(Cash ch)
        //{
        //    this.ch = ch;
        //}
        //public Cashier(MasterCard ms)
        //{
        //    this.ms = ms;
        //}
        //public Cashier(Debit db)
        //{
        //    this.db = db;
        //}
        //public Cashier(VisaCard vs)
        //{
        //    this.vs = vs;
        //}

        //public void Checkout(decimal amount)
        //{
        //    ch.Pay(amount);
        //} 
        #endregion
       
        private Ipayment payment;
        public Cashier(Ipayment payment)
        {
            this.payment = payment;
        }
        public void CheckOut(decimal amount)
        {
            payment.Pay(amount);
        }
    }
}
