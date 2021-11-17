using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment
{
    public class mathInt
    {
        public int GetAdd(int data)
        {
            data = data + 4;
            return data;
        }

        public decimal GetSubtract(decimal data)
        {
            data = data - 3;
            decimal Subt = Convert.ToInt32(data);           
            return Subt;
        }

        public int GetMultiply(int data)
        {
            data = data * 4;
            int Mult = Convert.ToInt32(data);
            return Mult;
        }
    }
}
