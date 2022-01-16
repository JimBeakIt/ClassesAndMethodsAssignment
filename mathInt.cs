using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment
{
    public class mathInt
    {
        public int Mat(int plus)
        {
            plus += 4;
            return plus;
        }

        public decimal Mat(decimal subt)
        {
            subt -= 3;
            int subtr = Convert.ToInt32(subt);
            return subtr;
        }

        public int Mat(string mul)
        {
            int times = Convert.ToInt32(mul);
            times *= 2;
            return times;
        }
    }
}
