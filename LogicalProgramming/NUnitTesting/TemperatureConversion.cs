using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.NUnitTesting
{
    class TemperatureConversion
    {
        public static double CelToFah()
        {
            Console.WriteLine("Enter the value in Celcius : ");
            double cel = Convert.ToDouble(Console.ReadLine());
            double fah = (9.0 / 5.0) * cel + 32;
            return fah;
        }

        public static double FahToCel()
        {
            Console.WriteLine("Enter the value in Fahrenheit : ");
            double fah = Convert.ToDouble(Console.ReadLine());
            double cel = (5.0 / 9.0) * (fah - 32);
            return cel;
        }
    }
}
