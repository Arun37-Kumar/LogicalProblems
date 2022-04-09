using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.NUnitTesting
{
    internal class SqrtNewtonMethod
    {
        public static void NewtonMethod()
        {
            Console.WriteLine("Enter non-negative number c : ");
            double c = Convert.ToDouble(Console.ReadLine());
            double epsilon = 1e-15;    // relative error tolerance
            double t = c;              // estimate of the square root of c

            // repeatedly apply Newton update step until desired precision is achieved
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            // print out the estimate of the square root of c
            Console.WriteLine("Result is : "+t);
        }
    }
}