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
    class CSalaried: CEmployee
    {
        private decimal GrossSalary { get; set; }

        public override decimal NetSalary(decimal _Gross, double _tax, double _commission)
        {
            _commission = 0;
            decimal Total;
            decimal mTax = (decimal)_tax;
            mTax = mTax / 100;
            Total = _Gross - (_Gross * mTax);
            return Total;
        }
    }
}
