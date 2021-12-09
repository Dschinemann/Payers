using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payers.Entities
{
    class Company : Payer
    {
        public int NumberOfEmployees { get; private set; }

        public Company(int numberOfEmployees, string name, double income) : base(name, income)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double tax()
        {
            double totalTax = 0;
            double taxDiscount = 0;

            if (NumberOfEmployees > 10)
            {
                taxDiscount = (Income * 0.14);
            }
            else
            {
                taxDiscount = (Income * 0.16);
            }
            return taxDiscount;
        }

    }
}
