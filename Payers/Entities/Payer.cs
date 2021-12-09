using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payers.Entities
{
    abstract class Payer
    {
        public string Name { get; private set; }
        public double Income { get; private set; }

        public Payer(string name, double income)
        {
            Name = name;    
            Income = income;
        }

        public abstract double tax();
    }
}
