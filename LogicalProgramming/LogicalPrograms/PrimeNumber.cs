using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.LogicalPrograms
{
    internal class PrimeNumber
    {
        public void isPrime()
        {
            Console.Write("\nEnter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            //Computation for prime
            for(int start = 2;start <= number; start++)
            {
                if(number%start == 0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
                Console.WriteLine("{0} is a prime number.", number);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number.", number);
            }
        }
    }
}
