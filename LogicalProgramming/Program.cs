using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Fibonacci Series
            //LogicalPrograms.Fibonacci fibSeries = new LogicalPrograms.Fibonacci();
            //fibSeries.CalculateFibonacciSeries();
            //Console.WriteLine();
            ////Perfect Number
            //LogicalPrograms.PerfectNumber perfectNumberCompute = new LogicalPrograms.PerfectNumber();
            //perfectNumberCompute.FindPerfectNumber();
            ////Prime Number
            //LogicalPrograms.PrimeNumber primeNumberCompute = new LogicalPrograms.PrimeNumber();
            //primeNumberCompute.isPrime();
            ////Reverse Number
            //LogicalPrograms.ReverseNumber reverNumberCompute = new LogicalPrograms.ReverseNumber();
            //reverNumberCompute.getReverse();
            //Coupon Number
            //LogicalPrograms.CouponNumber.DistinctCoupon();
            //LogicalPrograms.ElaspedTimeStopWatch.ElapsedTime();
            NUnitTesting.VendingMachine.CalculateNotes();

            double ConvertCelciusToFahrenheit = NUnitTesting.TemperatureConversion.CelToFah();
            Console.WriteLine("Celcius to Fahrenheit : "+ConvertCelciusToFahrenheit);

            double ConvertFahrenheitToCelcius = NUnitTesting.TemperatureConversion.FahToCel();
            Console.WriteLine("Fahrenheit to Celcius : "+ConvertFahrenheitToCelcius);
            Console.ReadLine();

        }
    }
}
