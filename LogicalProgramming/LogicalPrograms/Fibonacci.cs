using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.LogicalPrograms
{
     class Fibonacci
    {
        public void CalculateFibonacciSeries()
        {
            int firstNumber = 0;
            int secondNumber = 1;

            Console.WriteLine("Enter the number of terms to find series : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int thirdNumber = 0;
            int fibonacciNumber = 0;

            for (int i = 0; i < number; i++)
            {
                fibonacciNumber = firstNumber + secondNumber; // 0(first) + 1(second)
                thirdNumber = fibonacciNumber; // 0 + 1 = 1
                firstNumber = secondNumber; // 1
                secondNumber = thirdNumber ; // third number = 1
                Console.Write("{0} ",fibonacciNumber);
            }
        }
    }
}
