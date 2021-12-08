using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payers.Entities
{
    class Company : Payer
    {
        public int numberOfEmployees { get; private set; }
        public override double tax()
        {
            throw new NotImplementedException();
        }
    }
}
