using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.LogicalPrograms
{
    internal class PerfectNumber
    {
        public void FindPerfectNumber()
        {
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sumOfFactors = 0;

            // Calculating factors
            for (int factor = 1; factor < number; factor++)
            {
                if (number % factor == 0)
                {
                    sumOfFactors += factor;
                    Console.Write("{0} ",factor);
                }
            }

            //Check whether number is perfect or not
            if (number == sumOfFactors)
            {
                Console.WriteLine("\n{0} is a perfect number.", number);
            }
            else
            {
                Console.WriteLine("\n{0} is not a perfect number.", number);
            }
        }
    }
}
