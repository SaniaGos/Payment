 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    [Serializable]
    public class PaymentAccount
    {
        public static bool IsCalculate { get; set; }
        public int PaymentPerDay { get; set; }
        public int NumOfDay { get; set; }
        public int FinePerDay { get; set; }
        public int DaysOfDelay { get; set; }
        public int AmountDue { get; set; }
        public int Fine { get; set; }
        public int Total { get; set; }
        static PaymentAccount()
        {
            IsCalculate = true;
        }
        public PaymentAccount()
        {
            PaymentPerDay = 0;
            NumOfDay = 0;
            FinePerDay = 0;
            DaysOfDelay = 0;

           
        }
        public void Calculate()
        {
            AmountDue = PaymentPerDay * NumOfDay;
            Fine = FinePerDay * DaysOfDelay;
            Total = AmountDue + Fine;
        }

    }
}
