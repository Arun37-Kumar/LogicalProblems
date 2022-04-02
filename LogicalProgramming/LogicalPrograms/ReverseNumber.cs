using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.LogicalPrograms
{
    internal class ReverseNumber
    {
        public void getReverse()
        {
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int remainder = 0;
            int reverse = 0;
            while (number > 0)
            {
                remainder = number % 10;
                reverse = (reverse*10) + remainder;
                number /= 10;
            }
            Console.WriteLine("Number after reverse : {0}",reverse);
        }
    }
}
