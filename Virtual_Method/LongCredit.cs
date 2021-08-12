using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Method
{
    class LongCredit : Credit
    {
        private decimal sum;
        public override decimal Sum
        {
            get
            {
                return sum;
            }
            set
            {
                if (value > 1000)
                    sum = value;
            }
        }
    }
}
