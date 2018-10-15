using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_TAN_NAVARRO_GALANG
{
    class Program
    {
        static void Main(string[] args)
        {
            Double fin_sum, fin_diff, fin_mul, fin_div;
            DeclareVariables decvar = new DeclareVariables();
       

            fin_sum = decvar.summ();
            fin_diff= decvar.difff();
            fin_mul = decvar.mull();
            fin_div = decvar.divv();

            Console.WriteLine("The sum of " + DeclareVariables.num1 + " And " + DeclareVariables.num2 + " is " + fin_sum);
            Console.WriteLine("The difference of " + DeclareVariables.num1 + " And " + DeclareVariables.num2 + " is " + fin_diff);
            Console.WriteLine("The product of " + DeclareVariables.num1 + " And " + DeclareVariables.num2 + " is " + fin_mul);
            Console.WriteLine("The quotient of " + DeclareVariables.num1 + " And " + DeclareVariables.num2 + " is " + fin_div);

            Console.ReadKey();

        }
    }
}
