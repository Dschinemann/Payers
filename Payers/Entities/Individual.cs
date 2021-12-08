using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payers.Entities
{
    class Individual : Payer
    {
        public double HealthExpenditures { get; private set; }

        public override double tax()
        {
            double tax = 0;
            double taxDiscount = 0;

            if(Income < 20000.00)
            {
                tax = (Income * 0.15);
            }
            else
            {
                tax = (Income * 0.25);
            }

            if(HealthExpenditures > 0)
            {
                taxDiscount = tax - (HealthExpenditures * 0.50);
            }
            else
            {
                taxDiscount = tax;
            }

            return taxDiscount;
        }
    }
}
