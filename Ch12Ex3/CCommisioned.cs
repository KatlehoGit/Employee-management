/*2017115029
Katleho Moalosi
Assignment 1
CSIS2614*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12Ex3
{
    class CCommisioned : CEmployee
    {
        private decimal MonthlySales { get; set; }
        static private double Commision;
        public double dCommision
        {
            get { return Commision; }
            set
            {
                Commision = value;
            }
        }

        public override decimal NetSalary(decimal _monthlysales, double _tax, double _commission)
        {
            decimal Total;
            decimal mCommission = (decimal)_commission;
            mCommission = mCommission / 100;
            decimal mTax = (decimal)_tax;
            mTax = mTax / 100;
            Total = (_monthlysales * mCommission) - mTax;
            return Total;
        }

        
    }
}
