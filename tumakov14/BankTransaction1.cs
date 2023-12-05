using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov14
{
    internal class BankTransaction1
    {
        private double sum;
        private DateTime date;
        public double Sum { get; }
        public DateTime Date { get; }
        public BankTransaction1(double sum, DateTime date)
        {
            this.date = date;
            Sum = sum;
            Date = date;
        }

        public BankTransaction1()
        {

        }
        public BankTransaction1(double sum)
        {
            this.sum = sum;
            date = DateTime.Now;
        }
    }
}
