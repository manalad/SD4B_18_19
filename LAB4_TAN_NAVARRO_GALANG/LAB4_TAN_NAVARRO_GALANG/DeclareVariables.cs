using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_TAN_NAVARRO_GALANG
{
    class DeclareVariables
    {

        public static Double num1 = 2;
        public static Double num2 = 4; 
        public static Double sum, diff, mul, div;

        public Double summ()
        {
            sum = num1 + num2;
            return sum;

        }
        public Double difff()
        {
            diff = num1 - num2;
            return diff;
        }

        public Double mull()
        {
            mul = num1 * num2;
            return DeclareVariables.mul;
        }
        public Double divv()
        {
            div = num1 / num2;
            return div;
        }

    }
}
