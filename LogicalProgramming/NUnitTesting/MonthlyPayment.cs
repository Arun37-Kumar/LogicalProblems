using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.NUnitTesting
{
    internal class MonthlyPayment
    {
        public static void MonthlyPaymentCalculate()
        {
            double PrincipleAmount, Years, PercentInterest;
            double payment;

            Console.WriteLine("Enter the Principle Amount : ");
            PrincipleAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the number of year : ");
            Years = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Percent interest : ");
            PercentInterest = Convert.ToDouble(Console.ReadLine());


            double n = 12 * Years;
            double r = PercentInterest / (12 * 100);
        
            payment = (PrincipleAmount * r) / (1-Math.Pow(1+r,-n));

            Console.WriteLine("Final payment is : "+payment);
        }
    }
}
